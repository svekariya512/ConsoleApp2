using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class13
    {
        public static void five()
        {
            int terms, number;
            int current = 0;
            int sum = 0;

            Console.WriteLine("Enter the number of terms:");
            terms=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of terms:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= terms; i++)
            {

                    current = current * 10 + number;
                    Console.Write(current);
                    sum += current;

                    if (i < terms)
                        Console.Write("+");
                }

                Console.WriteLine("The sum of the series is: " + sum);
                Console.ReadLine();

            
        }

      
    }
}
