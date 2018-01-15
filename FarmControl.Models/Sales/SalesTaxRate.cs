using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SalesTaxRate
    {
        /*
         * SalesTaxRateID
         * StateProvinceID
         * TaxType1 = Tax applied to retail transactions.

2 = Tax applied to wholesale transactions.

3 = Tax applied to all sales, retail and wholesale, transactions.
TaxRate
Name
ModifiedDate
         * 
         */
        public SalesTaxRate()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public string TaxName { get; set; }
        public double TaxRateP { get; set; }
        public DateTime ModfiedDate { get; }
    }
}
