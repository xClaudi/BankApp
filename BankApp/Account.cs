using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Account
    {
        public string Currency { get; set; }
        public double Amount { get; set; }
        public int AccountNumber { get; set; }

        public List<Transaction> Transactions { get; set; }

        public bool DoTransaction(double ile, String dokogo)
        {
            this.Amount -= ile;
            Transactions.Add(new Transaction(Amount, dokogo));
            return true;
        }
    }
}
