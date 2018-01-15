using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Sales
{
    public class SalesOrderStatusHistory
    {
        public SalesOrderStatusHistory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public SalesOrder SalesOrder { get; set; }
        public SalesOrderStatus SalesOrderStatus { get; set; }
        public string ChangeDescription { get; set; }
        public string UserName { get; set; }
        public DateTime ModfiedDate { get; }
    }
}
