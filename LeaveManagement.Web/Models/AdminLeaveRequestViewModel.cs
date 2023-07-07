using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class AdminLeaveRequestViewModel
    {
        public AdminLeaveRequestViewModel(int totalRequests, int approvedRequests, int pendingRequests , int rejectedRequests, List<LeaveRequestViewModel> leaveRequests)
        {
            TotalRequests = totalRequests;
            ApprovedRequests = approvedRequests;
            PendingRequests = pendingRequests;
            RejectedRequests = rejectedRequests;
            LeaveRequests = leaveRequests;
        }

        [Display(Name = "Total Number of Requests")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }

        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}
