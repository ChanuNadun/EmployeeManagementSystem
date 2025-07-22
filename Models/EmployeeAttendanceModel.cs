using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class EmployeeAttendanceModel
    {
        public int EmployeeId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string Status { get; set; }
    }
}