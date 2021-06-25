using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using UserLogin.Enums;

namespace UserLogin.Utiles
{
    public static class EnumConverter
    {
        public static String GetActivityEnumValue(int index)
        {
            String activity = Enum.GetName(typeof(UserRoles), index);

            return activity;
        }
    }
}