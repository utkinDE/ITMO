using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17._1
{
    class BankAccount<T>
    {
        private T AccountNumber { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }

        public BankAccount(T accountNumber, double balance, string name)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Name = name;
        }

        public string GetInfo()
        {
            return $"{AccountNumber} {Balance} {Name}";
        }
    }
}