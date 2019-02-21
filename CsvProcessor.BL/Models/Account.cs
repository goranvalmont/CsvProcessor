using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace CsvProcessor.BL.Models
{
    public class Account : CsvBase
    {
        public Account()
        { }

        public Account(int accountId, int accountNumber, double amount)
        {
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.Amount = amount;
        }

        public int AccountId { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }
        
    }
}
