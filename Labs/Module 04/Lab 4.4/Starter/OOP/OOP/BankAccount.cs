using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class BankAccount
    {
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            private set
            {
                _accountNumber = value;
            }
        }
        private int _accountNumber;

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
            }
        }
        private decimal _balance;

        public BankAccount( int accountNumber )
            : this( accountNumber, 0 )
        {
        }

        public BankAccount( int accountNumber, decimal initialBalance )
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit( decimal amount )
        {
            Balance += amount;
        }

        public bool Withdraw( decimal amount )
        {
            if( Balance >= amount )
            {
                Balance -= amount;

                return true;
            }

            return false;
        }
    }
}
