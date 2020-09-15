using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class CheckingAccount : Account
    {
        private double fee;

        public CheckingAccount(double balance, double fee) : base(Balance)
        {
            this.fee = fee;
        }

        public new static double Balance { get; set; }

        public override void Deposit(double amount)
        {
            base.Deposit(amount);
            Balance -= fee;

        }

        public override bool Withdraw(double amount)
        {
            if (base.Withdraw(amount))
            {
                Balance -= fee;

                return true;
            }
            else
            {
                return false;
            }
        }

    }

}

