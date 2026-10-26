using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class14
    {
        public static void half()
        {
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                // Print leading spaces

                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= (2 * i) - 1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            
        }
            //Second half
            
            for (int i = rows - 1 ; i >= 1; i--)
            {
                // Print leading spaces

                for (int j = 1; j < rows - i; j++)
                {
                    Console.Write(" ");
                }
                // Print stars
                for (int k = 1; k <= (2 * i) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


    }

}

