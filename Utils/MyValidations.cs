using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utils
{
    public class MyValidations
    {
        /// <summary>
        /// Validate an email
        /// </summary>
        /// <param name="email">Email to validate</param>
        /// <returns>Bool - If it is an email</returns>
        public static bool IsEmail(string email)
        {
            if (email == null)
            { 
                return false;
            }

            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// Verifies if a person is a minor
        /// </summary>
        /// <param name="date">Date birth</param>
        /// <returns>Bool - If its a minor or not</returns>
        /// https://stackoverflow.com/questions/9/how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday
        public static bool IsMinor(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;

            if (DateTime.Now.Month < date.Month || (DateTime.Now.Month == date.Month && DateTime.Now.Day < date.Day))
            {
                age--;
            }

            if(age >= 18)
                return false;
            else
                return true;
        }

    }
}
