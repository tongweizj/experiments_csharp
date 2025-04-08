using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class VisaAccount : Account
    {
        private static Double INTEREST_RATE = 0.1995;
        private Double CredilLimit;
        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("VS-", balance)
        {
            this.CredilLimit = creditLimit;
        }
        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }

        public void DoPurchase(double amount, Person person) {
            if (!base.IsHolder(person.Name))
            {
                throw new AccountException("NAME_NOT_ASSOCIATED_WITH_ACCOUN.");
            }
            if (!person.IsAuthenticated)
            {
                throw new AccountException("USER_NOT_LOGGED_IN");
            }
            if ((base.Balance - amount) < CredilLimit)
            {
                throw new AccountException("CREDIT_LIMIT_HAS_BEEN_EXCEEDED");
            }

          
            base.Deposit(amount * (-1), person);
         
                
           
        }
        public override void PrepareMonthlyReport()
        {
            base.Balance -= base.LowestBalance * INTEREST_RATE / 12;

            base.Transactions.Clear();
        }
        public double GetCredilLimit() {
            return this.CredilLimit;
        }
    }
}
