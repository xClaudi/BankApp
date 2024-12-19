using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Transaction
    {
        public double Amount { get; set; }
        public String Merchant { get; set; }

        public Transaction(double amount, String merchant)
        {
            this.Amount = amount;
            this.Merchant = merchant;
        }
    }
}
