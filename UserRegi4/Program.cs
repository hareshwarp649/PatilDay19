using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");   //taking user input of password1
            string password1 = Console.ReadLine();
            PasswordNum.Password(password1);
            Console.ReadLine();

        }
    }
}
