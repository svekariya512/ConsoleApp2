
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IEmployee
    {
        void GetEmpDetails();
        void ShowEmpDetails();

    }
    class Emp : IEmployee
    {
        string name;
        string designation;
        int age;
        public void GetEmpDetails()
        {
            Console.WriteLine("Enter name :" + name);
            name = Console.ReadLine();
            Console.WriteLine("Enter Designation :" + designation);
            designation = Console.ReadLine();
            Console.WriteLine("Enter Age :" + age);
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowEmpDetails()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Designation :" + designation);
            Console.WriteLine("Age :" + age);
        }
    }
    internal class Class23
    {
        public static void Main(string[] args)
        {

            
            Emp emp = new Emp();
            emp.GetEmpDetails();
            emp.ShowEmpDetails();

            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");

            Console.ReadLine();
        }
    }
}
