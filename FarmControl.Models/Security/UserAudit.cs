using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.Security
{
    public class UserAudit
    {
        [Key]
        public int UserAuditId { get; }

        [Required]
        public FarmControlUser Sys_user { get; private set; }

        [Required]
        public DateTimeOffset Timestamp { get; private set; } = DateTime.UtcNow;

        [Required(ErrorMessage = "Missing Data"), EnumDataType(typeof(UserAuditEventType))]
        public UserAuditEventType AuditEvent { get; set; }

        public string IpAddress { get; private set; }
        public string Table_Field { get; set; }
        public string Record_ID { get; set; }
        public string AnyOtherInfo { get; set; }

        public static UserAudit CreateAuditEvent(FarmControlUser sysuser, UserAuditEventType auditEventType, string ipAddress, string table_field = "", string record_id = "", string anyOtherInfo = "") => new UserAudit { Sys_user = sysuser, AuditEvent = auditEventType, IpAddress = ipAddress, Table_Field = table_field, Record_ID = record_id, AnyOtherInfo = anyOtherInfo };
    }
    public enum UserAuditEventType
    {
        Login = 1,
        FailedLogin = 2,
        LogOut = 3,
        Update = 4,
        Add = 5,
        Delete = 6
    }
}
