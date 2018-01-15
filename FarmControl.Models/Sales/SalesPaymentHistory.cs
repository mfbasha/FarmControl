using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SalesPaymentHistory
    {
        public SalesPaymentHistory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int TransID { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public DateTime PaymentDate { get; set; }
        [DataType(DataType.Currency)]
        public double PaidAmount { get; set; }

        [DataType(DataType.Currency)]
        public double RemainingAmount { get; set; }


        public DateTime ModfiedDate { get;  }

    }
    public enum PaymentMethod
    {
        Bank_Check,Bank_Transfer,Cash,Credit_Card,Others
    }
}
