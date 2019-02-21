using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvProcessor.BL;
using CsvProcessor.BL.Models;

namespace CsvProcessorClient.TestDataFactory
{
    public static class BankFactory
    {
        public const string FileName = "Banks.csv";

        public static List<Bank> GetBanks()
        {
            List<Bank> banks = new List<Bank>();

            banks.Add(new Bank(1, "My first bank", "MFB123"));
            banks.Add(new Bank(2, "My second bank", "MFB122"));
            banks.Add(new Bank(3, "My third bank", "MFB133"));
            banks.Add(new Bank(4, "My fourth bank", "MFB144"));


            return banks;
        }
    }
}
