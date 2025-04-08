using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Person
    {
        private string Password;
        public readonly string SIN;

        public Boolean IsAuthenticated { get; private set; }
        public String Name {  get; private set; }


        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
            Password = sin.Substring(0, 3);
        }

        public void Login( string password)
        {
            // 1. Throw an AccountException object this the if the argument does not match the password
            // 2. If the argument matches the password the IsAuthenticated property is set to true
            // 3. This method does not display anything

            if (Password.Equals(password))
            {
                IsAuthenticated = true;
            }
            else
            {
                throw new AccountException("Incorrect Password");
            }
        }
        public void Logout()
        {
            IsAuthenticated = false;
        }
        public override string ToString() {
            // It does not take any parameter but returns a string representing the name of the person and if he is authenticated or not.
            String authStr = IsAuthenticated ? " is authenticated!":"not authenticated!";
            return $"Name: {Name}, {authStr}";
        }
    }
}
