using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class EmployeeLeave
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime LeaveDate { get; set; }
        public string Reason { get; set; }

        public virtual Employee Employee { get; set; }
    }
}