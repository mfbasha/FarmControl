using FarmControl.Models.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Accounting
{
    public class FinancialTransaction
    {
        public FinancialTransaction()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public FinancialAccount AccountID { get; set; }
        [EnumDataType(typeof(PaymentMethod))]
        public PaymentMethod PaymentMethod { get; set; }
        [MaxLength(50)]
        public string ServiseReference { get; set; }//any ID that can refernce the transaction like SalesOrder,Employee ID, etc
        [EnumDataType(typeof(TransactionStatus))]
        public TransactionStatus TransactionStatus { get; set; }
        [EnumDataType(typeof(Service))]
        public Service ServiceID { get; set; }
        public double  TransactionAmoun{ get; set; }
        public DateTime ModfiedDate { get; }
    }
    public enum TransactionStatus
    {
        Completed,Cancelled, Disputed
    }
}
