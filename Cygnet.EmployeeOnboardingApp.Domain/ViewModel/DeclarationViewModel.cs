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
   public class DeclarationViewModel:BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [DisplayName("KYC Details")]
        public string Kyc_Details { get; set; }
        [DisplayName("Member of EPF Schema?")]
        public string Is_Mem_Epf_Schema { get; set; }
        [DisplayName("Date of Allotment of Insurance Number")]
        public DateTime Dt_Allot_Ins_No { get; set; }
        [DisplayName("Date of Issue of TIC")]
        public DateTime Dt_Issue_Tic { get; set; }
    }
}
