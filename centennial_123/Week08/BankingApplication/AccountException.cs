using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class AccountException : Exception
    {
        public const String ACCOUNT_DOES_NOT_EXIST = "Sorry, account does not exist!";
        public const String CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "CREDIT_LIMIT_HAS_BEEN_EXCEEDED";
        public const String NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "NAME_NOT_ASSOCIATED_WITH_ACCOUN.";
        public const String NO_OVERDRAFT = "NO_OVERDRAFT";
        public const String PASSWORD_INCORRECT = "PASSWORD_INCORRECT";
        public const String USER_DOES_NOT_EXIST = "USER_DOES_NOT_EXIST";
        public const String USER_NOT_LOGGED_IN = "USER_NOT_LOGGED_IN";

        public AccountException() : base(){
        }
        public AccountException(string reason) : base(reason)
        {
        }
    }
}
