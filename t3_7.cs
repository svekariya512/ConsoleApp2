using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
//7. Define a base class Employee with a CalculateSalary() method and derive Manager and Developer classes from it.
//Override the CalculateSalary() method in each derived class and display their respective salaries.

     class Employee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Calculating salary");
        }
    }
    class Manager : Employee
    {
        public override void CalculateSalary()
        {
            int salary = 8000;
            Console.WriteLine("Manager Salary:" +  salary);
        }
    }

    class Developer : Employee
    {
        public override void CalculateSalary()
        {
            int salary = 5000;
            Console.WriteLine("Developer Salary:" + salary);
        }
    }

    class t3_7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : Shreeya Vekariya");
            Console.WriteLine("Roll No : 24SOECE11050");
            Employee e;
            e = new Manager();
            e.CalculateSalary();

            e = new Developer();
            e.CalculateSalary();

            Console.ReadLine();
        }

        }
}
