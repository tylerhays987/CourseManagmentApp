using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementApp.Models;
using CourseManagementApp.Services;

namespace CourseManagementApp.Services
{
    public static class DiscussionService
    {
        private static List<Discussion> _discussions = new List<Discussion>
        {
            new Discussion { Id = 1, User = "Student1", Message = "What time is the next class?", PostedOn = DateTime.Now.AddHours(-2) },
            new Discussion { Id = 2, User = "Instructor1", Message = "The next class is at 10:00 AM tomorrow.", PostedOn = DateTime.Now.AddHours(-1) }
        };

        public static List<Discussion> GetDiscussions()
        {
            return _discussions;
        }

        public static void AddDiscussion(Discussion discussion)
        {
            _discussions.Add(discussion);
        }
    }
}