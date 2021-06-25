using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Web;
using UserLogin.Enums;
using UserLogin.Models;
using UserLogin.Utiles;

namespace UserLogin
{
    public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();
        static public List<string> CurrentSessionActivities
        {
            get
            {
                return currentSessionActivities;
            }
            set { currentSessionActivities = value; }
        }

        static public void LogActivity(Users u, ActivityEnum activity)
        {
            var username = u != null ? u.name : "Unknown";
            var role = u != null ? EnumConverter.GetActivityEnumValue(u.role) : "Unknown";

            string activityLine = DateTime.Now + ";"
                + username + ";"
                + role + ";"
                + activity;

            if (File.Exists("C:/Users/Dell/Desktop/realProject/UserLogin/UserLogin/Text.txt") == true)
            {
                using (var writer = new StreamWriter("C:/Users/Dell/Desktop/realProject/UserLogin/UserLogin/Text.txt", true))
                {
                    writer.WriteLine(activityLine);
                }
            }
            currentSessionActivities.Add(activityLine);
        }
    }
}