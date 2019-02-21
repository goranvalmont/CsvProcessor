using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvProcessor.BL;
using CsvProcessor.BL.Models;
using CsvProcessorClient.TestDataFactory;

namespace CsvProcessorClient
{
    class Program
    {
        static void Main(string[] args)
        {

            string testDataFolderPath = @"C:\ProjectsRepos\CsvProcessor\CsvProcessorClient\TestData\";

            // initialise writer classes
            CsvHelper<Account> csvAccount = new CsvHelper<Account>(testDataFolderPath + AccountFactory.FileName);
            CsvHelper<Bank> csvBank = new CsvHelper<Bank>(testDataFolderPath + BankFactory.FileName);
            CsvHelper<Transaction> csvTransaction = new CsvHelper<Transaction>(testDataFolderPath + TransactionFactory.FileName);

            // test the save functionality

             csvAccount.WriteToFile(AccountFactory.GetAccounts());
            
             csvBank.WriteToFile(BankFactory.GetBanks());

             csvTransaction.WriteToFile(TransactionFactory.GetTransactions());


            // test the read functionality

            List<Account> csvReadAccounts = csvAccount.ReadFromFile().ToList();
            Console.WriteLine("Accounts");
            foreach (Account acc in csvReadAccounts)
            {
                Console.WriteLine(acc.ConvertToCsv());
            }
           
            List<Bank> csvReadBank = csvBank.ReadFromFile().ToList();
            Console.WriteLine("Banks");
            foreach (Bank bank in csvReadBank)
            {
                Console.WriteLine(bank.ConvertToCsv());
            }

            List<Transaction> csvReadTransaction = csvTransaction.ReadFromFile().ToList();
            Console.WriteLine("Transactions");
            foreach (Transaction tran in csvReadTransaction)
            {
                Console.WriteLine(tran.ConvertToCsv());
            }

            Console.ReadLine();

        }
    }
}
