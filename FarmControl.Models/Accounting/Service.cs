using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Accounting
{
    public class Service
    {
        //Sales order, Maintnance, General Cost, Adjustment,Refund, work Cost, Salary Payroll, Advance Staff Payment,Staff Deduction,Customer Payment, Customer refund,General,Dispute,Withdrwaal,Commission
        public Service()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Currency)]
        public double DebitAmount { get; set; }
        [DataType(DataType.Currency)]
        public double CreditAmount { get; set; }
        public DateTime ModfiedDate { get; }
    }
}
