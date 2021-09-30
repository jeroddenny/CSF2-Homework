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

            // Vehicle
            Vehicle v1 = new Vehicle();
            v1.Make = "Hyundai";
            v1.Model = "Tucson";
            v1.Year = 2017;
            v1.Weight = 3500f;

            Console.WriteLine(v1);

            //Login
            Login l1 = new Login();
            l1.UserName = "SAran";
            l1.PassWord = "Metroid";

            Console.WriteLine(l1);

            

        }//end Main()
    }//end class
}//end namespace
