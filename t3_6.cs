using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //6. Define a base class Vehicle containing vehicle number and model name, and derive a Car
    //class from it.Use the base class constructor and derived class methods to accept and display complete car details.
    class Vehicle
    {
        protected string number;
        protected string mname;

        public Vehicle(string n, string mn)
        {
            number = n;
            mname = mn;
        }
    }

        class Car : Vehicle

        {
        private string carn;

        public Car ( string n, string mn, string cn) : base (n,mn)
        {
            carn = cn; 
        }
        public void Display()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("\n car detail:");
            Console.WriteLine("number:" + number);
            Console.WriteLine("model:" + mname);
            Console.WriteLine("car name:" + carn);
            

        }
    }
    class t3_5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : Shreeya Vekariya");
            Console.WriteLine("Roll No : 24SOECE11050");
            string n, mn, cn;

            Console.WriteLine("enter a number:");
            n = Console.ReadLine();

            Console.WriteLine("enter a model name:");
            mn = Console.ReadLine();

            Console.WriteLine("enter a car name:");
            cn = Console.ReadLine();

            Car c = new Car(n, mn, cn);

            c.Display();
        }
    }


    }

