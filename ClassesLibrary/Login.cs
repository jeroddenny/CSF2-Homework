using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Login
    {
        //fields
        private string _userName;
        private string _passWord;

        //properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }


        //constructors
        public Login() { }
        public Login(string userName, string passWord)
        {
            UserName = _userName;
            PassWord = _passWord;
        }
        //methods
        public override string ToString()
        {
         return string.Format($"Username : {UserName} \nPassword: {PassWord}");
        }

    }
}
