using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //8. Define an abstract class Payment with an abstract method to calculate the payment amount.Create derived classes
    //for different payment types and implement the calculation using method overriding.
    abstract class Payment
    {
        public abstract void CalculatePayment();

    }
    class CashPayment : Payment
    {

        private double amount;
        public CashPayment(double amt)
        {
            amount = amt;
        }


        public override void CalculatePayment()
        {

            Console.WriteLine("Cash Payment Amount: " + amount);
        }
    }

    class CreditCardPayment : Payment
    {
        private double amount;
        private double interestRate;
        public CreditCardPayment(double amt, double rate)
        {
            amount = amt;
            interestRate = rate;
        }
        public override void CalculatePayment()
        {
            double totalAmount = amount + (amount * interestRate);
            Console.WriteLine("Credit Card Payment Amount: " + totalAmount);
        }
    }

    class t3_8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : Shreeya Vekariya");
            Console.WriteLine("Roll No : 24SOECE11050");
            Payment p;
            p = new CashPayment(100);
            p.CalculatePayment();
            p = new CreditCardPayment(200, 0.05);
            p.CalculatePayment();
            Console.ReadLine();
        }
    }
}


