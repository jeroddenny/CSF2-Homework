using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _studentID;
        private float _gpa;


        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
                                  
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }
        public string StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }

        }
        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value; }

        }

        //Constructors (ctors)
        public Student() { }
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = _studentID;
            GPA = gpa;
        }

       
        //Methods 
        public override string ToString()
        {
            return string.Format("Student: \nFirst Name: {0}\nLast Name: {1} \nID: {2} \nGPA {3}", FirstName, LastName, StudentID, GPA);
        }
        
    }//end class
}//end namespace
