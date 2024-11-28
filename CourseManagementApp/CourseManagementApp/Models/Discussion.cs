using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp.Models
{
    public class Discussion
    {
        public int Id { get; set; }
        public string User { get; set; } // User who posted
        public string Message { get; set; } // Content of the discussion
        public DateTime PostedOn { get; set; } // Date and time posted
    }
}
