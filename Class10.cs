using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class10
    {
        public static void Gender()
        {

            string name;
            char gender;

            Console.WriteLine("enter a name:");
            name = Console.ReadLine();

            Console.WriteLine("enter a gender(m/f):");
            gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("MR " + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("MS " + name);
            }
            else
            {
                Console.WriteLine("Invalid gender");
            }
            Console.ReadLine();
        }
        }
}
