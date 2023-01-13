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
        public LeaveTypeVM LeaveType { get; set; }
        public string LeaveTypeId { get; set; }

        public IEnumerable<EmployeeVM> Employees { get; set; }
        public IEnumerable<LeaveTypeVM> LeaveTypes { get; set; }
    }
}
