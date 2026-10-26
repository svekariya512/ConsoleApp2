using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class4
    {
        public static void table()
        {
            int number, i, result;
            Console.WriteLine("Enter Number For table : ");

            number = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while (i <= 10)
            {
                result = number * i;
                Console.WriteLine(number + " * " + i + " = " + result);
                i++;
            }

            Console.ReadLine();
        }
    }
}