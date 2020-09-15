using BankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Deposit(100);
            acc.Withdraw(50);
            Console.WriteLine("balance is," + acc.Balance);
            Console.ReadKey();
        }
    }
}
