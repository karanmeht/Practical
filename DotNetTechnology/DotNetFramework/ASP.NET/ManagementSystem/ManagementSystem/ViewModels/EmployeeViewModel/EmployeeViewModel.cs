using ManagementSystem.Models.Employee;
using ManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManagementSystem.ViewModels.EmployeeViewModel
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }
        public Countries Country { get; set; }
    }
}