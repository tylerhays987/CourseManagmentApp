using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Schedule { get; set; }
        public string Instructor { get; set; }
        public List<string> Materials { get; set; } = new List<string>();
        public List<string> Books { get; set; } = new List<string>();
    }
}
