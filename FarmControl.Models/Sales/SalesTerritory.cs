using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SalesTerritory
    {
        public SalesTerritory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int TerritoryID { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }

        public double SalesYTD { get; set; }
        public double SalesLastYear { get; set; }
        public double CostYTD { get; set; }
        public double CostLastYear { get; set; }

        public DateTime ModfiedDate { get;  }
    }
}
