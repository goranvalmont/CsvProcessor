using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvProcessor.BL.Models
{
    public class Transaction : CsvBase
    {
        public Transaction()
        { }

        public Transaction(int transactionId, int bankId, int accountIdTo, int accountIdFrom, double amount)
        {

            this.TransactionId = transactionId;
            this.BankId = bankId;
            this.AccountIdFrom = accountIdFrom;
            this.AccountIdTo = accountIdTo;
            this.Amount = amount;

        }

        public int TransactionId { get; set; }
        public int BankId { get; set; }
        public int AccountIdTo { get; set; }
        public int AccountIdFrom { get; set; }
        public double Amount { get; set; }

    }
}
