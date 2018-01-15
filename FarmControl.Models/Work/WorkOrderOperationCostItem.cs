using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Work
{
    public class WorkOrderOperationCostItem
    {
        public WorkOrderOperationCostItem()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public int Id { get; set; }
        public WorkOrder WorkOrder { get; set; }
        public OperationCostItem OperationCostItem  { get; set; }
        public DateTime PaymentDate { get; set; }
        public double PaidAmount { get; set; }

        public DateTime ModfiedDate { get; }
    }
}
