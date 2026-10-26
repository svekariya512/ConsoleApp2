using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class12
    {
        public static void As()
        {
            int number, original, remainder, result = 0;
            Console.WriteLine("Enter a Armstrong number:");
            number= Convert.ToInt32(Console.ReadLine());

            original = number;
            while (number > 0)
            {
                remainder = number % 10;
                result = result + (remainder * remainder * remainder);
                number = number/ 10;
            }

            if (original == result)
            {
                Console.WriteLine("this an Armstrong number");
            }
            else
            {
                Console.WriteLine("this not an Armstrong number");
            }
            Console.ReadLine();
        }
    }
}
