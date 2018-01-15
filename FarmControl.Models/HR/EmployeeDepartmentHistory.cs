using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.HR
{
    public class EmployeeDepartmentHistory
    {
        public EmployeeDepartmentHistory()
        {
            ModfiedDate = DateTime.Now.Date;
        }
        public Employee Employee { get; set; }
        public Department MyProperty { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateTime ModfiedDate { get;  }
    }
}
