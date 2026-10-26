
using System;
namespace ConsoleApp2
{
    internal class Class19
    {
        public static void element()
        {
            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");
            int[] arr = new int[5];
            int sum = 0;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter element {0}:", i);
                string str = Console.ReadLine();
                arr[i] = Convert.ToInt32(str);

            }
            for (int i = 0; i < 5; i++)
            {
                sum = sum + arr[i];
            }
             Console.WriteLine("sum of array elements is: " + sum);
            Console.Read();
        }

    }
}
