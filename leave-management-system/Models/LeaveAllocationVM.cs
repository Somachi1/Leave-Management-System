using leave_management_system.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace leave_management_system.Models
{
    public class LeaveAllocationVM
    {
        
        public int Id { get; set; }
        [Required]
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        [Required]
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        [Required]
        public DetailsLeaveTypeVM LeaveType { get; set; }
        public string LeaveTypeId { get; set; }

        public IEnumerable<SelectListItem> Employees { get; set; }
        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}
