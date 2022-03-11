using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMobileNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter mobile number in this format : 00 0000000000"); 
            //string MobileNum = Console.ReadLine();
            //MobileNumber.MobileNumValid(MobileNum);
            //Console.ReadLine();
            Console.Write("Enter Last Name : ");   //taking user input of Last name
            string lastname = Console.ReadLine();
            LastName.lastName(lastname);
            Console.ReadLine();
        }
    }
}
