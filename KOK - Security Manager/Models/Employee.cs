using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOK___Security_Manager.Models
{
    public enum ContractType
    {
        FullTimeContract,
        HalfTimeContract,
        ThreeQuartersTimeContract,
        CasualContract
    }
    public enum ShiftType
    {
        A,
        B,
        C
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HireDate { get; set; }
        public bool WeaponUse { get; set; }
        public ContractType Contract { get; set; }
        public ShiftType Shift { get; set; }
        public bool IsKR { get; set; }
        
    }
}
