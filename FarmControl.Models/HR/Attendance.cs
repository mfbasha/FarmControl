using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.HR
{
    public class Attendance
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public DateTime AttendanceDay { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }
    }
}
