using FarmControl.Models.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Work
{
    public class WorkOrder
    {
        public WorkOrder()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        [Key]
        public int WorkOrderID { get; set; }
        public Product Product { get; set; }
        //TODO:Lert for DueDate
        public DateTime DueDate { get; set; }
        //OperationSequence
        public int ProducedQty { get; set; }
        public int StockedQty { get; set; }
        public int ScrappedQty { get; set; }
        public ScrapReason ScrapReason { get; set; }
        //TODO: Add Employee responsible

        public LocationFarm LocationFarm { get; set; }

        public DateTime ScheduledStartDate { get; set; }
        public DateTime ScheduledEndDate { get; set; }
        public DateTime ActualStartDate { get; set; }
        //TODO: Alert if passed duedate
        public DateTime ActualEndDate { get; set; }

        public double PlannedCost { get; set; }
        public double ActualCost { get; set; }
        public DateTime ModfiedDate { get;  }
    }
}
