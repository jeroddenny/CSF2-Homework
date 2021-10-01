using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student

            
            
            Student s1 = new Student();

            s1.FirstName = "Samus";
            s1.LastName = "Aran";
            s1.StudentID = "SAran";
            s1.GPA = 3.5f;
            

            Console.WriteLine(s1);
            Console.WriteLine("");
            #endregion

            
            #region Vehicle
            
            Vehicle v1 = new Vehicle();
            v1.Make = "Hunter";
            v1.Model = "Gunship";
            v1.Year = 1994;
            v1.Weight = 5500f;

            Console.WriteLine(v1);
            Console.WriteLine("");
            #endregion


            #region Login

            

            Login l1 = new Login();
            l1.Username = "SAran";
            l1.Password = "JustinBailey";

            Console.WriteLine(l1);
            Console.WriteLine("");
            #endregion


            #region ContactInfo

            

            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "528";
            c1.City = "K-2L";
            c1.State = "Zebes";
            c1.Zip = "19874";
            c1.Phone = "(800)255-3700";
            c1.Email = "samus.aran@metroidvania.com";

            ContactInfo c2 = new ContactInfo();
            c2.StreetAddress = "123 Bag End";
            c2.City = "Hobbiton";
            c2.State = "The Shire";
            c2.Zip = "38500";
            c2.Phone = "(555)224-4467";
            c2.Email = "frodobaggin@theshire.org";
            Console.WriteLine(c1);
            Console.WriteLine("");
            #endregion

            #region Customer
            Customer cust1 = new Customer();
            cust1.CustomerID = "Hobbit";
            cust1.FirstName = "Frodo";
            cust1.LastName = "Baggins";
            cust1.CustomerInfo = c2;

            Console.WriteLine(cust1);
            Console.WriteLine("");
            #endregion

            #region CreditCardAccount
            CreditCardAccount card1 = new CreditCardAccount();
            card1.AccountNumber = 8675309;
            card1.CustomerInfo = cust1;
            card1.Balance = 500.87m;
            card1.IsPastDue = false;
            card1.AnnualInterestRate = .015m;

            Console.WriteLine(card1);
            Console.WriteLine("");


            #endregion


            #region Book

            Book b1 = new Book();
            b1.Title = "The Lord of the Rings";
            b1.Author = "J.R.R Tolkien";
            b1.NumberOfPages = 1178;

            Book b2 = new Book();
            b2.Title = "Game of Thrones";
            b2.Author = "George R.R. Martin";
            b2.NumberOfPages = 694;

            Console.WriteLine(b1);
            Console.WriteLine("");
            Console.WriteLine(b2);
            Console.WriteLine("");

            #endregion


            #region Library
            List<Book> books1 = new List<Book>() { b1, b2 };
            //books1.Add(b1);
            //books1.Add(b2);

            Library lib1 = new Library();
            lib1.Books = books1;
            lib1.LibraryName = "Truman Library";
            lib1.StreetAddress = "500 W US Hwy 24";
            lib1.City = "Independence";
            lib1.State = "Missouri";
            lib1.Zip = "64050";

            Console.WriteLine(lib1);
            Console.WriteLine("");



            #endregion
        }//end Main()
    }//end class
}//end namespace
