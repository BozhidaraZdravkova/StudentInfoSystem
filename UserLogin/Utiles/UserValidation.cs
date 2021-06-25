using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserLogin.Models;

namespace UserLogin.Utiles
{
    public static class Validator
    {
        public static bool ValidateUserInput(ref Users user)
        {

            // user = UserData.isUserPassCorrect(Username, Password);
            Boolean emptyUserName;
            //String ErrorMsg;
            emptyUserName = user.name.Equals(String.Empty);
            if (emptyUserName == true)
            {
                user.errMessage = "ne e posocheno potrebitelsko ime";

                return false;
            }

            Boolean emptyPassword;
            emptyPassword = user.pass.Equals(String.Empty);
            if (emptyPassword == true)
            {
                user.errMessage = "ne e posochena parola";

                return false;
            }

            if (user.name.Length < 5 || user.pass.Length < 5)
            {
                user.errMessage = "Too short";

                return false;

            }

            return true;
        }
    }
}