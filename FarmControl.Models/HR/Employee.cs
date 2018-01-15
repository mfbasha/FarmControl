using FarmControl.Models.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmControl.Models.HR
{
    public class Employee
    {

        public Employee()
        {
            ModfiedDate = DateTime.Now.Date;
        }  
        [Key]
        [MaxLength(15)]
        public string SSN { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string FamilyName { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Phone]
        public string Mobile { get; set; }
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime BirthDay { get; set; }
        [EnumDataType(typeof(JobTitle))]
        public JobTitle CurrentJob { get; set; }
        [MaxLength(15)]
        [EnumDataType(typeof(Employee))]
        public string ManagerSID { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
        public string Address { get; set; }
        [EnumDataType(typeof(MilitaryState))]
        public MilitaryState Militarystate { get; set; }
        [EnumDataType(typeof(MartialState))]
        public MartialState Martialstae { get; set; }
        [DataType(DataType.Upload)]
        public byte[] EmployeeImage { get; set; }
        [Required]
        [EnumDataType(typeof(CurrentFlag))]
        public CurrentFlag CurrentFlag { get; set; }
        [Required]
        [EnumDataType(typeof(SalariedFlag))]
        public SalariedFlag SalaryFlag { get; set; }
        //public double SalaryRate { get; set; }
        [DefaultValue(0)]
        public int VacationHours { get; set; }
        [DefaultValue(0)]
        public int SickLeaveHours { get; set; }
        public IEnumerable<Attendance> Attendance { get; set; }
        public IEnumerable<FinancialAccount> FinancialAccounts { get; set; }
                                           //TODO: public Department Department { get; set; }
        public DateTime ModfiedDate { get;  }
    }
    public enum Gender
    {
        Male,Female
    }
    public enum MilitaryState
    {
        Exempted,Fullfilled,None
    }
    public enum MartialState
    {
        Married, Single, Divorced, Widowed
    }
    public enum CurrentFlag
    {
        InActive,Active,Leave
    }
    public enum SalariedFlag
    {
        Hourly,Weekly,Monthly,Per_Activity
    }
}
