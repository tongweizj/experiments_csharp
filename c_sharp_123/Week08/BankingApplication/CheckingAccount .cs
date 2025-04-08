using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class CheckingAccount : Account
    {
        private static Double COST_PER_TRANSACTION = 0.05;
        private static Double INTEREST_RATE = 0.005;
        private Boolean hasOverdraft; 


        public CheckingAccount(double balance = 0, bool hasOverdraft = false) : base("CK-", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }
        public new void Deposit(double amount, Person person) {
            if (base.IsHolder(person.Name))
            {
                base.Deposit(amount, person);
            }
        }
        public void Withdraw(double amount, Person person)
        {
            try
            {
                if (!base.IsHolder(person.Name))
                {
                    throw new AccountException("NAME_NOT_ASSOCIATED_WITH_ACCOUN.");
                }
                if (!person.IsAuthenticated)
                {
                    throw new AccountException("USER_NOT_LOGGED_IN");
                }
                if (amount > base.Balance)
                {
                    throw new AccountException("NO_OVERDRAFT");
                }
                base.Deposit(amount * (-1), person);
            }
            catch (AccountException ex)
            {
                Console.WriteLine("AccountException：" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("SystemException：" + ex.Message);
            }
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = 0.0;
            double interest = 0.0;
            foreach (Transaction item in base.Transactions) {
                serviceCharge += COST_PER_TRANSACTION;
            }
            interest += (base.Balance * INTEREST_RATE) / 12;
            Console.WriteLine($"{serviceCharge} - {interest}");
            base.Balance = base.Balance + interest - serviceCharge;

            base.Transactions.Clear();
        }
}
}
