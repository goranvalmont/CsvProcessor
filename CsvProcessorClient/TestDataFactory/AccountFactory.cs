using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvProcessor.BL;
using CsvProcessor.BL.Models;

namespace CsvProcessorClient.TestDataFactory
{
    public static class AccountFactory
    {
        public const string FileName = "Accounts.csv";

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account(1, 111111, 500.00));
            accounts.Add(new Account(2, 222222, 1500.00));
            accounts.Add(new Account(3, 333333, 2500.00));
            accounts.Add(new Account(4, 444444, 5500.00));
            accounts.Add(new Account(5, 555555, 3500.00));

            return accounts;
        }
    }
}
