using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Extensions
{
    public static class UserExtensions
    {
        public static string GetFullName(this User thisUser)
        {
            return $"{thisUser.FirstName} {thisUser.LastName}";
        }
    }
}
