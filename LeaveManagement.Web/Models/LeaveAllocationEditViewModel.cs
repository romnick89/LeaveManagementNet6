﻿using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationEditViewModel : LeaveAllocationViewModel
    {
        public string? EmployeeId { get; set; }
        public int LeaveTypeId { get; set; }
        public EmployeeListViewModel? Employee { get; set; }
    }
}
