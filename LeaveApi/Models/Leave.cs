using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveApi.Models
{
    public class Leave
    {
        [Key]
        public int leave_id { get; set; }
        public int employee_id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string employee_name { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        [Column(TypeName = "nvarchar(15)")]
        public string status { get; set; }


    }
}
