using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace CsvProcessor.BL.Models
{
    public class Bank : CsvBase
    {
        public Bank()
        { }

        public Bank(int bankID, string name, string bic)
        {
            this.BankId = bankID;
            this.Name = name;
            this.BIC = bic;
        }

        public int BankId { get; set; }
        public string Name { get; set; }
        public string BIC { get; set; }
       
    }
}
