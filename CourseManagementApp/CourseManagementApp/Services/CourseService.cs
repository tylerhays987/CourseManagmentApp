using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementApp.Models;
using System.Collections.Generic;

namespace CourseManagementApp.Services
{
    public static class CourseService
    {
        // Simulated in-memory list of courses
        private static List<Course> _courses = new List<Course>
        {
            new Course { Id = 1, Name = "Math 101", Description = "Basic Mathematics", Instructor = "Dr. Smith", Credits = 3 },
            new Course { Id = 2, Name = "Physics 201", Description = "Fundamental Physics", Instructor = "Dr. Johnson", Credits = 4 },
            new Course { Id = 3, Name = "Chemistry 301", Description = "Advanced Chemistry", Instructor = "Dr. Brown", Credits = 3 }
        };

        // Public method to retrieve the courses
        public static List<Course> GetCourses()
        {
            return _courses;
        }
    }
}