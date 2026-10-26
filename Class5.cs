using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class5
    {
        public static void Conversion()
        {
            string str, result;
            Console.WriteLine("Enter a string:");
            str = Console.ReadLine();

            result = str.ToUpper();
            Console.WriteLine(result);
        }
    }
}
