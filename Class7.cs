using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class7
    {
        public static void Digit()
        {
            string str;
            //string result = "";
            Console.WriteLine("enter a mobile number:");
            str = Console.ReadLine();

            int n = str.Length;

            for (int i = 0; i < n; i++)
            {

                if (i < n / 2) 
                {
                    Console.Write(str[i]);
                }
                else
                {
                    Console.Write("x");
                }


            }

        }

    }
}
