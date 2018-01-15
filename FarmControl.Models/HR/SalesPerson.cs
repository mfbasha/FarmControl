using FarmControl.Models.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.HR
{
    public class SalesPerson:Employee
    {
        
        public SalesTerritory SalesTerritory { get; set; }
        public double SalesQuota { get; set; }
        public double BonusDue { get; set; }
        public double CommissionPct { get; set; }
        public double SalesYTD { get; set; }
        public double SalesLastYear { get; set; }
        

        

    }
}
