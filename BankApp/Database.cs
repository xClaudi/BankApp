using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Database
    {
        public Database() { }

        public Account getAccountDetails()
        {
            List<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction(-133, "dildoes"));
            transactions.Add(new Transaction(-1356, "sexdolls"));
            transactions.Add(new Transaction(356, "blowjobs"));

            return new Account
            {
                Amount = 3450,
                AccountNumber = 12345,
                Currency = "PLN",
                Transactions = transactions
            };
        }
    }
}
