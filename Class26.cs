using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    delegate void StudentDetails();
    internal class Class26
    {
        static void DisplayName()
        {
            Console.WriteLine("Student Name: shreeya");
        }
        static void DiaplayCourse()
        {
            Console.WriteLine("Course :  B.Tech");
        }
        static void DiaplySemester()
        {
            Console.WriteLine("Semester : 5th");
        }
        public static void Main(string[] args)
        {
            StudentDetails sd;

            sd = DisplayName;
            sd += DiaplayCourse;
            sd += DiaplySemester;

            Console.WriteLine("Student Details : ");
            sd();

            Console.WriteLine("NAME:VEKARIYA SHREEYA KANTILAL");
            Console.WriteLine("ENROLLMENT NO:24SOECE11050");
            Console.ReadLine();
        }
    }
}
