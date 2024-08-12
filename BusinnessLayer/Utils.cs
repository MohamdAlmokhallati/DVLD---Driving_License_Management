using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public static class Utils
    {
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
