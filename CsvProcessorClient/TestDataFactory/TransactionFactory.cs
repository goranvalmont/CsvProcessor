using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvProcessor.BL;
using CsvProcessor.BL.Models;

namespace CsvProcessorClient.TestDataFactory
{
    public static class TransactionFactory
    {
        public const string FileName = "Transactions.csv";

        public static List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            transactions.Add(new Transaction(1,1,1,2,100.00));
            transactions.Add(new Transaction(1, 1, 2, 1, 50.00));
            transactions.Add(new Transaction(1, 1, 2, 3, 50.00));
            transactions.Add(new Transaction(1, 1, 2, 4, 50.00));
            transactions.Add(new Transaction(1, 1, 2, 5, 50.00));
            transactions.Add(new Transaction(1, 1, 2, 6, 50.00));
            transactions.Add(new Transaction(1, 1, 2, 7, 50.00));
            transactions.Add(new Transaction(1, 1, 2, 8, 50.00));


            return transactions;

        }

    }
}
