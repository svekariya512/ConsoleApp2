using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class2
    {
        public static void Factorial()
        {
            int number,i,fact = 1;

            Console.WriteLine("enter a number for factorial:");
            number = Convert.ToInt32(Console.ReadLine());
            for (i=1; i <= number; i++)
            {
                fact = fact*i;
            }
            Console.WriteLine("factorial of" +number+ " is:" +fact);
            Console.Read();
        }

    } 
        }
    

