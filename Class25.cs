
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate int Calculate(int a, int b);
    internal class Class25
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter first number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number :");
            int b = Convert.ToInt32(Console.ReadLine());

            Calculate c;
            //delagatename varname;

            c = Add;
            Console.WriteLine("Addition : " + c(a, b));

            c = Subtract;
            Console.WriteLine("Subtraction :" + c(a, b));

            c = Multiplication;
            Console.WriteLine("Multiplication :" + c(a, b));

            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");

            Console.ReadLine();
        }
    }
}

