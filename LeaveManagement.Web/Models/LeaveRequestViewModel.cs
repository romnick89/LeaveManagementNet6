using System.ComponentModel.DataAnnotations;


namespace LeaveManagement.Web.Models
{
    public class LeaveRequestViewModel : LeaveRequestCreateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type")]
        public LeaveTypeViewModel LeaveType { get; set; }

        [Display(Name = "Date Requested")]
        [DataType(DataType.Date)]
        public DateTime DateRequested { get; set; }

        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        public string? RequestingEmployeeId { get; set; } 
        public EmployeeListViewModel Employee { get; set; }
    }
}
