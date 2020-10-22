using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsefulUtilities.Interfaces;

namespace UsefulUtilities.Services
{
    public class UtilityService : IUtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;
        // private readonly string Email;

        public UtilityService()
        {
            colors = new List<string>
            {
                "red",
                "blue",
                "lime",
                "orange",
                "magenta"
             };

            random = new Random();
        }
        //public UtilityService(string email)
        //{
        //    Email = email;
        //}

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }
        public string ValidateEmail(string email)
        {
            string returnText = "";
            if (String.IsNullOrEmpty(email))
            {
                returnText = "Please give your email!";
            }
            else
            {
                if (email.Contains('@') && email.Contains('.'))
                {
                    returnText = $"<p style=\"color:green\">{email} is a valid email address</p>";
                }
                else
                {
                    returnText = $"<p style=\"color:red\">{email} is not a valid email address</p>";
                }
            }
            return returnText;
        }
    }
}
