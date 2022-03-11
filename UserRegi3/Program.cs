using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseRegistration3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Email ID: ");   //taking user input of Email ID
            string Email = Console.ReadLine();
            UserEmail.EmailId(Email);
            Console.ReadLine();
        }
    }
}
