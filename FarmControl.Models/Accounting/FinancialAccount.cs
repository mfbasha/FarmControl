using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Accounting
{
    public class FinancialAccount
    {
        public FinancialAccount()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        [MaxLength(16)]
        public string AccountNumber { get; set; }
        [MaxLength(50)]
        public string AccountName { get; set; }
        [DataType(DataType.Currency)]
        public double CurrentBalance { get; set; }
        [DataType(DataType.Currency)]
        public double AmountOnHold { get; set; }
        public AccountType AccountType { get; set; }

        public DateTime ModfiedDate { get; }
    }
   
}
