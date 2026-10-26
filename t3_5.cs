using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Define a class Book with book ID, title, author, and price using properties.Create multiple book objects and
//display their complete details using constructors and methods.
namespace ConsoleApp2
{
     class Book
    {
        public int Bookid { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }

        public Book (int id, string Title, string Author,double Price)
        {
            Bookid = id;
            title = Title;
            author = Author;
            price = Price;
        }

        public void Display()
        {
            Console.WriteLine("enter a book id : " + Bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author :" + author);
            Console.WriteLine("price :" + price);
            Console.WriteLine("======================================================");
        }

        class t3_5
            { 
            static void Main(String[] args)
            {
                // Create multiple book objects
                Book b1 = new Book(101, "C# Programming", "Mital", 450);
                Book b2 = new Book(102, "ASP.NET Basics", "Shreeya", 550);
                Book b3 = new Book(103, "Database Systems", "Hiral", 600);

                // Display details
                b1.Display();
                b2.Display();
                b3.Display();

                Console.WriteLine("Name : Shreeya Vekariya");
                Console.WriteLine("Enrollment No. : 24SOECE11050");
                Console.ReadLine();

            }

        }

    }
}
