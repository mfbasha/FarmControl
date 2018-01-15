using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.HR
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string DepartmentName { get; set; }
    }
}
