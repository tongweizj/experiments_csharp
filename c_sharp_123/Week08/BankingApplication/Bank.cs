using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using System.IO;

namespace BankingApplication
{
    internal static class Bank
    {
        private static List<Account> accounts;
        private static List<Person> persons;

        static Bank()
        {
            Initialize();
        }
        static void CreatePersons()
        {
            persons = new List<Person>()
            {
                new Person("Narendra", "1234-5678"), //p0
                new Person("Ilia", "2345-6789"), //p1
                new Person("Tom", "3456-7890"), //p2
                new Person("Syed", "4567-8901"),
                new Person("Arben", "5678-9012"), //p4
                new Person("Patrick", "6789-0123"),
                new Person("Yin", "7890-1234"), //p6
                new Person("Hao", "8901-2345"),
                new Person("Jake", "9012-3456") //p8
            };
        }
       static void CreateAccounts()
        {
            accounts = new List<Account>{
                new VisaAccount(),              //VS-100000
                new VisaAccount(550, -500),     //VS-100001
                new SavingAccount(5000),        //SV-100002
                new SavingAccount(),            //SV-100003
                new CheckingAccount(2000),      //CK-100004
                new CheckingAccount(1500, true) //CK-100005
            };
       }

        static void Initialize()
        {
            CreateAccounts();
            CreatePersons();
            accounts[0].AddUser(persons[0]);
            accounts[0].AddUser(persons[1]);
            accounts[0].AddUser(persons[2]);

            accounts[1].AddUser(persons[3]);
            accounts[1].AddUser(persons[4]);
            accounts[1].AddUser(persons[2]);

            accounts[2].AddUser(persons[0]);
            accounts[2].AddUser(persons[5]);
            accounts[2].AddUser(persons[6]);

            accounts[3].AddUser(persons[5]);
            accounts[3].AddUser(persons[6]);

            accounts[4].AddUser(persons[5]);
            accounts[4].AddUser(persons[7]);
            accounts[4].AddUser(persons[8]);

            accounts[5].AddUser(persons[5]);
            accounts[5].AddUser(persons[6]);
        }

        public static void PrintAccounts() {
            Console.WriteLine(String.Join("\n", accounts));
        }


        public static void SaveAccounts(string filename)
        {
            //Create and initialise a serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //saves the json string to the file
            File.WriteAllText(filename, serializer.Serialize(accounts));
        }
        public static void PrintPersons() { 
           Console.WriteLine(String.Join("\n", persons));
        }

        public static Person GetPerson(string name) {
            foreach (Person person in persons) { if (person.Name == name) return person; }
            throw new AccountException("Sorry, person does not exist!");
        }

        public static Account GetAccount(string number) {
            foreach (Account account in accounts) { if (account.Number == number) return account; }
            throw new AccountException("Sorry, account does not exist!");
        }

    }
}
