using System;
namespace ConsoleApp2
{
    internal class Class17
    {
        public static void name()
        {
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");

            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " "  + lastName);

            Console.ReadLine();
        }
    }
}
