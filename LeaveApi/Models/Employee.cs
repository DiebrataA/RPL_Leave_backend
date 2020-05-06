using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApi.Models
{
    public class Employee
    {
        [Key]
        public int employee_id { get; set; }
        [Column(TypeName ="nvarchar(30)")]
        public string username { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string name { get; set; }
        [Column(TypeName = "nvarchar(25)")]
        public string job_title { get; set; }
        public int leave_remaining { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string password { get; set; }
    }
}
