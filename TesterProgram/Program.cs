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
            //Student

           Student s1 = new Student();

                s1.FirstName = "Samus";
                s1.LastName = "Aran";
                s1.StudentID = "SAran";
                s1.GPA = 3.5f;
            

            Console.WriteLine(s1);
            Console.WriteLine("");
            // Vehicle
            Vehicle v1 = new Vehicle();
            v1.Make = "Hunter";
            v1.Model = "Gunship";
            v1.Year = 1994;
            v1.Weight = 5500f;

            Console.WriteLine(v1);
            Console.WriteLine("");
            //Login
            Login l1 = new Login();
            l1.Username = "SAran";
            l1.Password = "JustinBailey";

            Console.WriteLine(l1);
            Console.WriteLine("");
            //ContactInfo
            ContactInfo c1 = new ContactInfo();
            c1.StreetAddress = "528";
            c1.City = "K-2L";
            c1.State = "Zebes";
            c1.Zip = "19874";
            c1.Phone = "(800)255-3700";
            c1.Email = "samus.aran@metroidvania.com";

            Console.WriteLine(c1);
        }//end Main()
    }//end class
}//end namespace
