using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseRegistration3
{
    internal class UserEmail
    {
        public static void EmailId(string mail)
        {
            string emailid = "^[a-z]{3}[.][a-z0-9]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
            Regex regex = new Regex(emailid);

            if (regex.IsMatch(mail))
            {
                Console.WriteLine("Email Id is valid");
            }
            else
            {
                Console.WriteLine("Email Is Invalid,Please Enter Valid email Id\n Refer and try again: abc.xyz@bl.co.in");
            }

        }
    }
}
