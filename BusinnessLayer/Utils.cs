using System;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public static class Utils
    {

        public static bool isValidPass(string password,ref string reason)
        {
            // this Functions takes the Unencrypted password and returns if it valid

            if (String.IsNullOrEmpty(password))
            {
                reason = "The Password can't be Empty.";
                return false;
            }

            if (password.Length < 4)
            {
                reason = "Password must be at least 4 characters long.";
                return false;
            }

            return true;
        }


        public static bool IsNumber(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }

            // Check if the string is a valid integer or a floating-point number
            bool isInteger = int.TryParse(str, out _);
            bool isDouble = double.TryParse(str, out _);

            return isInteger || isDouble;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

    }
}
