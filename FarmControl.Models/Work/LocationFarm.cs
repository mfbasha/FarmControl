using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Work
{
    public class LocationFarm
    {
        //TODO: Farm Location
        [Key]
        public int LocationID { get; set; }
        public string FarmName { get; set; }
        public int FarmSize { get; set; }

    }
}
