using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;


namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateViewModel : IValidatableObject
    {
        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Request Comments")]
        public string? RequestComments { get; set; }

        [Display(Name = "Total Leave Days")]
        public int TotalLeaveDays { get; set; }

        //implement custom validation
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(StartDate > EndDate)
            {
                yield return new ValidationResult("The Start Date must be before the End Date", new[] { nameof(StartDate), nameof(EndDate) });
            }
            if(RequestComments?.Length > 500)
            {
                yield return new ValidationResult("The comments are too long must be less than 500 characters", new[] { nameof(RequestComments) });
            }
        }
    }
}
