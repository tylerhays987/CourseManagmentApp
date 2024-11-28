using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementApp.Models;
using CourseManagementApp.Services;

namespace CourseManagementApp.Services
{
    public static class UserSession
    {
        public static User LoggedInUser { get; private set; }

        public static void Login(User user)
        {
            LoggedInUser = user;
        }

        public static void Logout()
        {
            LoggedInUser = null;
        }

        public static bool IsUserLoggedIn => LoggedInUser != null;
    }
}