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
   public class BankDetailsViewModel:BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [DisplayName("Account Number")]
        public string Acc_No { get; set; }
        [Required]
        [DisplayName("IFSC Code")]
        public string Ifsc_Code { get; set; }
        [Required]
        [DisplayName("PAN Card Number")]
        public string Pan_No { get; set; }
        [DisplayName("UAN Number")]
        public string Uan_No { get; set; }
        [DisplayName("Insuance Number")]
        public string Ins_No { get; set; }
        [DisplayName("Mediclaim Number")]
        public string Mediclaim { get; set; }
        [DisplayName("Life Insurance Number")]
        public string Life_Ins { get; set; }
        [DisplayName("Family Pension Scheme Number")]
        public string Fam_PensionScheme { get; set; }
        [DisplayName("Provident Fund Number")]
        public string Pf_No { get; set; }
    }
}
