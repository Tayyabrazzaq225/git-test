using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class SavingAccount : Account
    {
        private double interestRate;

        public SavingAccount(double balance, Double interestRate) : base(Balance)
        {
            this.interestRate = interestRate;
        }

        public static double Balance { get; }

        public double CalculateInterest()
        {
            return Balance * interestRate / 100;
        }
    }
}
