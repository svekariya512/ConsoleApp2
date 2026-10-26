using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class t3_3
    {
        static void Main(string[] args)
        {
            string sentence;

            Console.Write("Enter a sentence: ");
            sentence = Console.ReadLine();


            Console.WriteLine("Uppercase: " + sentence.ToUpper());


            Console.WriteLine("Replace Spaces: " + sentence.Replace(" ", "-"));


            Console.WriteLine("Trimmed Sentence: " + sentence.Trim());


            Console.WriteLine("Length: " + sentence.Length);

            Console.WriteLine("Name : Shreeya Vekariya");
            Console.WriteLine("Enrollment No. : 24SOECE11050");
            Console.ReadLine();
        }
    }
}
