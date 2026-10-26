using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class18
    {
        public static void oper()
        {
            double a, b;
            Console.Write("Enetr First Number : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enetr Second Number : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine("Addition : " + (a + b));
            Console.WriteLine("Subtraction : " + (a - b));
            Console.WriteLine("Multiplication : " + (a * b));

            if (b != 0)
            {
                Console.WriteLine("Division : " + (a / b));
                Console.WriteLine("Modulus : " + (a % b));

            }
            else
            {
                Console.WriteLine("Division  = Cannot divide by Zero ! ");
                Console.WriteLine("Modulus  =  Cannot divide by Zero !");

            }

            Console.WriteLine("Relational operators");
            Console.WriteLine("a > b : " + (a > b));
            Console.WriteLine("a < b : " + (a < b));
            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b));

            Console.WriteLine("Logical operators");
            Console.WriteLine("both are positive (&&):" + (a > 0 && b > 0));
            Console.WriteLine("at least one is positive (||):"  + (a > 0 || b > 0));
            Console.WriteLine("are they not equal? (!):" + !(a == b ));

            Console.ReadLine();


        }
    }
}