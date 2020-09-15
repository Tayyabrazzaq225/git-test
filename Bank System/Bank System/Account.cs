using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        public double Balance { get; set; }
        private double WithdrawAmount { get; set; }
        public Account(double balance = 0.0)
        {
            this.Balance = balance;
        }
        private Account()
        {

        }
        public virtual void Deposit(double amount)
        {
            this.Balance = amount + Balance;
        }
        public virtual bool Withdraw(double WdAmount)
        {
            if (WdAmount > Balance)
            {
                Console.WriteLine("Debit Amount Exceeded Account Balance.");
                return false;
            }
            else
            {
                this.Balance = Balance - WdAmount;
                return true;
            }
        }


    }
}
