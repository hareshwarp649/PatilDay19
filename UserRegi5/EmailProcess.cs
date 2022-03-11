using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration5
{
    internal class EmailProcess
    {
        public static void EmailSamp(string[] name)
        {
            string email = "^[a-zA-Z0-9]+[+-._]{0,1}[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]*[@][a-zA-Z0-9]+[.][a-zA-Z0-9]{2,3}([.]?[a-zA-Z]{2,3}){0,1}$";
            

            Regex regex = new Regex(email);            
            foreach (var word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid.");
                }
                else
                    Console.WriteLine(word + " is invalid.");
            }

        }
    }
}
