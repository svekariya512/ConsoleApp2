using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //10. Define a class LibraryAccount with a private number of issued books and public
    //methods to issue, return, and display the number of books.Create multiple objects
    //and demonstrate controlled access to the data.
    class LibraryAccount
    {
        private int issuedBooks;

        public LibraryAccount()
        {
            issuedBooks = 0;
        }

        public void IssueBook()
        {
            issuedBooks++;
            Console.WriteLine("Book Issued Successfully");
        }

        public void ReturnBook()
        {
            if (issuedBooks > 0)
            {
                issuedBooks--;
                Console.WriteLine("Book return successfully");
            }
            else
            {
                Console.WriteLine("No books to return.");
            }
        }

        public void DisplayIssuedBooks()
        {
            Console.WriteLine("Total issued books: " + issuedBooks);
        }

        class t3_10
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Name : Shreeya Vekariya");
                Console.WriteLine("ENRollment No : 24SOECE11050");
                LibraryAccount s1 = new LibraryAccount();
                LibraryAccount s2 = new LibraryAccount();

                Console.WriteLine("student1");
                s1.IssueBook();
                s1.IssueBook();
                s1.DisplayIssuedBooks();

                Console.WriteLine("student2");
                s2.IssueBook();
                s2.ReturnBook();
                s2.DisplayIssuedBooks();
                Console.ReadLine();
            }
        }
    }
}
