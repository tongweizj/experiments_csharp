using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal abstract class Account
    {
        public readonly List<Person> Holders = new List<Person>();
        public readonly List<Transaction> Transactions = new List<Transaction>();
        public readonly String Number;
        private static int LAST_NUMBER=100000;

        public Double Balance { get; protected set; }
        public Double LowestBalance { get; protected set; }

        public Account(string type, double balance)
        {
            Balance = balance;
            LowestBalance = balance;
            Number = type + LAST_NUMBER;
            LAST_NUMBER++;
        }
        public void AddUser(Person person)
        {
            Holders.Add(person);
        }
        public void Deposit(double amount, Person person) {
            // a.Increase(or decrease) Balance by the amount specified by its argument
            this.Balance += amount;

            // b.Update LowestBalance based on the current value of Balance
            this.LowestBalance = this.Balance;

            // c.Create a Transaction object based on the current time(use DateTime.Now), the AccountNumber, the amount(specified by the argument), a person object(as specified by the argument and the Balance
            this.Transactions.Add(new Transaction(this.Number, amount, this.Balance, person, DateTime.Now));
            // d.Adds the above object to the list of transactions

        }

        public bool IsHolder(String name) {
            foreach (Person person in Holders) { if (person.Name == name) return  true; }
            return false;
        }
        public abstract void PrepareMonthlyReport();

        public override String ToString()
        {
            return $"AccountNumber: {Number}, \nHolders: {String.Join(", ",this.Holders)}, \nBalance: {this.Balance}, \nTransactions:\n {String.Join(" ", this.Transactions)}\n";
        }
    }

}
