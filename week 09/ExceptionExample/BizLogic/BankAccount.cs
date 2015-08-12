using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614.Bank
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal openingBalance)
        {
            this.balance = openingBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (hasSufficientFunds(amount))
            {
                balance -= amount;                
            }
            else
            {
                throw new NoSufficientFundsException(this, amount);
              //  throw new NoSufficientFundsSimpleException("No Sufficient Funds - From No Sufficient Funds Simple Exception");
              //  throw new Exception("No Sufficient Funds - From General Exception");
            }
        }

        private bool hasSufficientFunds(decimal amount)
        {
            return balance >= amount;
        }

        public decimal Balance { get { return balance; } }

        public override string ToString()
        {
            return string.Format("Balance: {0:N2}", this.Balance);
        }
    }
}
