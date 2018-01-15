using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.HR
{
    public class EmployeePayHistory
    {
        public EmployeePayHistory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime TransactionValueDate { get; set; }
        public DateTime TransactionActualDate { get; set; }
        [EnumDataType(typeof(PaymentType))]
        public PaymentType PaymentType { get; set; }
        [DataType(DataType.Currency)]
        public double SalaryRate { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double SalaryAmount { get; set; }
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        public double PaidAmount { get; set; }
        [DataType(DataType.Currency)]
        [DefaultValue(0)]
        public double RemainingAmount { get; set; }
        [EnumDataType(typeof(SalariedFlag))]
        public SalariedFlag SalaryFlag { get; set; }

        public DateTime ModfiedDate { get;  }
    }
    public enum PaymentType
    {
        Due,In_Advance
    }
}
