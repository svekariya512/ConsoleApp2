using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class6
    {
        public static void Toggle()
        {
            string str;
            Console.WriteLine("Enter a string for toggle case:");
            str = Console.ReadLine();

            string result = "";

            foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else
                {
                    result += char.ToUpper(ch);
                }

            }
            Console.WriteLine(result);
        }


    }
}
