using CourseManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementApp.Services
{
    public static class DataService
    {
        private static List<Course> courses = new List<Course>();
        private static List<User> users = new List<User>();

        // Get all courses
        public static List<Course> GetCourses() => courses;

        // Add a new course
        public static void AddCourse(Course course) => courses.Add(course);

        // Enroll a user in a course
        public static void EnrollUserInCourse(int userId, int courseId)
        {
            var user = users.Find(u => u.UserId == userId);
            user?.EnrolledCourses.Add(courseId);
        }

        // Get all enrolled courses for a user
        public static List<Course> GetEnrolledCourses(int userId)
        {
            var user = users.Find(u => u.UserId == userId);
            return courses.FindAll(c => user.EnrolledCourses.Contains(c.CourseId));
        }
    }
}