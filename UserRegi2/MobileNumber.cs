using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserMobileNum
{
    internal class MobileNumber
    {
        public static void MobileNumValid(string number)
        {
            
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(Mobnumber);

            if (regex.IsMatch(number))
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Mobile number is Invalid,Please Enter Valid MObile Number format.");
            }
        }
    }
}
