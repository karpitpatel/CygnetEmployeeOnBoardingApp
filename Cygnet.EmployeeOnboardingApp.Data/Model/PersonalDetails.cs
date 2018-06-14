using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class PersonalDetails : BaseEntity
    {
        public string Name { get; set; }
        public string Father_Name { get; set; }
        public string Sex { get; set; }
        public string Marital_Stat { get; set; }
        public string Date_Anniv { get; set; }

        public DateTime Dob { get; set; }

        // public DateTime Dob { get; set; }
        public string Name_Company { get; set; }

        public string Designation { get; set; }
        public string Department { get; set; }
        public string Blood_Grp { get; set; }
        public string Allergy { get; set; }
        public string Ailment { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}