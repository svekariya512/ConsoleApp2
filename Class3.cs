using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class3
    {
        public static void Sum()
        {
            int a, b, c, result;
            Console.WriteLine("enter a number1:");
            String Str= Console.ReadLine();
            a = Convert.ToInt32(Str);

            Console.WriteLine("enter a number2:");
            String Str1 = Console.ReadLine();
            b = Convert.ToInt32(Str1);

            Console.WriteLine("enter a number3:");
            String Str2 = Console.ReadLine();
            c = Convert.ToInt32(Str2);

            result = a + b + c;
            Console.WriteLine("result is:" + result);
            Console.ReadLine();
        }

    }
}
