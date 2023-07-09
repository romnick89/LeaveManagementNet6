using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.IRepositories;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<Employee> _userManager;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, UserManager<Employee> userManager, ILeaveAllocationRepository leaveAllocationRepository) : base(context)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task ChangeApprovalStatus(int leaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(leaveRequestId);
            leaveRequest.Approved = approved;


            if (approved)
            {
                var allocation = await _leaveAllocationRepository.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);
                int daysRequested = leaveRequest.TotalLeaveDays;
                allocation.NumberOfDays -= daysRequested;                

                await _leaveAllocationRepository.UpdateAsync(allocation);
            }

            await UpdateAsync(leaveRequest);
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateViewModel model)
        {
            //retrieve logged in user 
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);

            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;
            leaveRequest.TotalLeaveDays = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays +1;

            await AddAsync(leaveRequest);
        }

        public async Task<AdminLeaveRequestViewModel> GetAdminLeaveRequestList()
        {
            var leaveRequests = await _context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestViewModel(
                leaveRequests.Count,
                leaveRequests.Count(q => q.Approved == true),
                leaveRequests.Count(q => q.Approved == null),
                leaveRequests.Count(q => q.Approved == false),
                _mapper.Map<List<LeaveRequestViewModel>>(leaveRequests)
                );
            foreach ( var leaveRequest in model.LeaveRequests )
            {
                leaveRequest.Employee = _mapper.Map<EmployeeListViewModel>(await _userManager.FindByIdAsync(leaveRequest.RequestingEmployeeId));
            }
            return model;
        }

        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            return await _context.LeaveRequests.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<EmployeeLeaveRequestViewModel> GetLeaveRequestsDetails()
        {
            //retrieve logged in user 
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
            //retrieve user allocations by user id
            //only fetch the leave allocations
            var leaveAllocations = (await _leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var leaveRequest = _mapper.Map<List<LeaveRequestViewModel>>(await GetAllAsync(user.Id));

            var model = new EmployeeLeaveRequestViewModel(leaveAllocations, leaveRequest);

            return model;
        }

        public async Task<LeaveRequestViewModel?> GetLeaveRequestAsync(int? id)
        {
            var leaveRequest = await _context.LeaveRequests
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == id);

            if(leaveRequest == null)
            {
                return null;
            }

            var model = _mapper.Map<LeaveRequestViewModel>(leaveRequest);
            model.Employee = _mapper.Map<EmployeeListViewModel>(await _userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));
            return model;
        }
    }
}
