using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class t3_1
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Enter a year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year.");
            }
            else
            {
                Console.WriteLine(year + " is Not a Leap Year.");
            }
            Console.WriteLine("Name : Shreeya Vekariya");
            Console.WriteLine("Enrollment No. : 24SOECE11050");
            Console.ReadLine();
        }
    }
}
