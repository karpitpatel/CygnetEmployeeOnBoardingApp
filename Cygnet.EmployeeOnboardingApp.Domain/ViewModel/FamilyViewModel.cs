using Cygnet.EmployeeOnboardingApp.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class FamilyViewModel:BaseViewModel
    {
       public int Id { get; set; }

        // public int FamId { get; set; }
        public string Name { get; set; }
        public string Relation { get; set; }
        public string Contact { get; set; }
        public string Occupation { get; set; }
        public string Dob { get; set; }
        public string Aadhar_No { get; set; }
        public string Residing_tog { get; set; }
        public int UserId { get; set; }
       
    }
}
