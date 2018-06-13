using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
   public class FamilyDetailsViewModel:BaseViewModel
    {
        //  public int EmpId { get; set; }
        //  public int FamId { get; set; }
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Occupation { get; set; }
        public string Dob { get; set; }
        [DisplayName("Aadhar Card Number")]
        public string Aadhar_No { get; set; }
        [DisplayName("Are you Residing Together?")]
        public string Residing_tog { get; set; }
        [DisplayName("Residing Town")]
        public string Residing_Town { get; set; }
    }
}
