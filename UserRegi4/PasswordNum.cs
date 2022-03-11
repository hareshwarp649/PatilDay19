using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration4
{
    internal class PasswordNum
    {
        public static void Password(string pass)
        {
            string pwd = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$";
            Regex regex = new Regex(pwd);                                           //creating a regex named obj with regular pwd.
            if (regex.IsMatch(pass))
            {
                Console.WriteLine(pass + " is valid.");
            }
            else
                Console.WriteLine(pass + " is invalid. Password must contain atleast one capital letter,one number,one special character");
        }
    }
}
