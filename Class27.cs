
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class BankAccount
    {
        public delegate void DepositHandler();

        //public event delegatename nameofevent;

        public event DepositHandler DepositEvent;

        public void Deposit(double amount)
        {
            Console.WriteLine("Amount Deposited : " + amount);

            if (DepositEvent != null)
            {
                DepositEvent();  //calling an event
            }
        }
    }
    internal class Class27
    {
        static void DepositMessage()
        {
            Console.WriteLine("Event : Amount deposited successfully.");
        }
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.DepositEvent += DepositMessage;
            account.Deposit(50000);

            Console.WriteLine("Name : SHREEYA VEKARIYA");
            Console.WriteLine("Enrollment No. : 24SOECE11050");
            Console.ReadLine();
        }
    }
}


