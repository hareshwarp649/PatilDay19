using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserMobileNum
{
    internal class LastName
    {
        public static void lastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid.\n Please Enter Last name start with capital letter and maximum 3 characters");
            }
        }
    }
}
