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
            Student s1 = new Student();

                s1.FirstName = "Samus";
                s1.LastName = "Aran";
                s1.StudentID = "SRan";
                s1.GPA = 3.5f;
            

            Console.WriteLine(s1);

        }//end Main()
    }//end class
}//end namespace
