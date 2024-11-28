using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementApp.Services;
using CourseManagementApp.Models;

namespace CourseManagementApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int UserId { get; set; }
        public string Role { get; set; } // "Student" or "Instructor"
        public List<int> EnrolledCourses { get; set; } = new List<int>();
    }
}
