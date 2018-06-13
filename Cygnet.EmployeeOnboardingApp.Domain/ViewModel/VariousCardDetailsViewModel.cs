using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
  public class VariousCardDetailsViewModel:BaseViewModel
    {
        
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [DisplayName("Passport Number")]
        public string Passport_No { get; set; }
        [DisplayName("Validity of Passport")]
        public string Passport_Validity { get; set; }
        [DisplayName("ESIC Number")]
        public string Esic_No { get; set; }
        [DisplayName("Vehicle Number")]
        public string Vehicle_No { get; set; }
        [DisplayName("Pension Payment Order Number")]
        public string Pension_Payment_OrderNo { get; set; }
        [DisplayName("Scheme Certificate Number")]
        public string Scheme_Certificate_No { get; set; }
        [Required]
        [DisplayName("Aadhar Card Number")]
        public string Aadhar_No { get; set; }
        [DisplayName("Election Number")]
        public string Election_No { get; set; }
    }
}
