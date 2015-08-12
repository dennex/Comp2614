using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614.Bank
{
    public class NoSufficientFundsException : Exception
    {
        private BankAccount account;
        private decimal transactionAmount;

        public NoSufficientFundsException(BankAccount account, decimal transactionAmount)
            : base("There are not sufficient funds to perform this transaction.")
        {
            this.account = account;
            this.transactionAmount = transactionAmount;
        }

        public BankAccount Account { get { return account; } }

        public decimal TransactionAmount { get { return transactionAmount; } }
    }


    public class NoSufficientFundsSimpleException : Exception
    {
        public NoSufficientFundsSimpleException(string message)
            : base(message)
        {

        }
    }
}
