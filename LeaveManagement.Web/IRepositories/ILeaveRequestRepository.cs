using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.IRepositories
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task CreateLeaveRequest(LeaveRequestCreateViewModel model);
        Task<EmployeeLeaveRequestViewModel> GetLeaveRequestsDetails();
        Task<LeaveRequestViewModel?> GetLeaveRequestAsync(int? id);
        //overload GetAllAsync() method
        //@param string employeeId
        Task<List<LeaveRequest>> GetAllAsync(string employeeId);
        Task<AdminLeaveRequestViewModel> GetAdminLeaveRequestList();
        Task ChangeApprovalStatus(int leaveRequestId, bool approved);
        Task CancelStatus(int leaveRequestId, bool cancelled);
    }
}
