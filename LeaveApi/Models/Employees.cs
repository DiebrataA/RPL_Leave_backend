using System;
using System.Collections.Generic;

namespace LeaveApi.Models
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int LeaveRemaining { get; set; }
        public string Password { get; set; }
    }
}
