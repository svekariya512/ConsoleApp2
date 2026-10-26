using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class9
    {
        public static void  Series()
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " "); //printing 0 and 1
            for(int i = 2; i < 10; ++i) //loop starts from 2 because 0 and 1 are already printed
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
