using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    /* The only purpose of this class is to capture the data values for each transaction */

    struct Transaction

    {
        public String AccountNumber { get; }
        public double Amount { get; }
        public double EndBalancd { get; }
        public Person Originator { get; }
        public DateTime Time { get; }
        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalancd = endBalance;
            Originator = person;
            Time = time;
        }
        public override string ToString()
        {
            //  returns a string representing the account number, name of the person, the amount and the time that this transition was completed. [
            return $"AccountNumber: {AccountNumber}, name: {Originator.Name}, amount: {Amount}, time: {Time.ToShortTimeString()}, Deposit: {EndBalancd}\n";
        }
    }
}