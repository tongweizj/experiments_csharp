using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class SavingAccount : Account
    {
        Double COST_PER_TRANSACTION = 0.05;
        Double INTEREST_RATE = 0.015;
        Boolean hasOverdraft;
        public SavingAccount(double balance = 0, bool hasOverDraft = false) : base("SV-", balance)
        {
            this.hasOverdraft = hasOverDraft;
        }
        public new void Deposit(double amount, Person person)
        {
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
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void PrepareMonthlyReport()
        {
            double serviceCharge = 0.0;
            double interest = 0.0;

            foreach (Transaction item in base.Transactions)
            {
                serviceCharge += COST_PER_TRANSACTION;
            }
            interest += base.LowestBalance * INTEREST_RATE / 12;
            base.Balance = base.Balance + interest - serviceCharge;

            base.Transactions.Clear();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
