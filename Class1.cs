using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        public static void Even_odd()
        {
            //Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            //Console.WriteLine("ENROLLMENT NO:24SOECE11050");
            int number;
            Console.WriteLine("enter a number:");
            String str = Console.ReadLine();
            //number = Convert.ToInt32(Console.ReadLine());
            number = Convert.ToInt32(str);
            if (number % 2 == 0) 
            {
                Console.WriteLine("enter a number is even:");
            }
            else
            {
                Console.WriteLine("number is odd:");
            }
            Console.ReadLine();
        }
     }
}
