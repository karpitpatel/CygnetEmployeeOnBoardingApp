using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class BankDetails : BaseEntity
    {
        public string Acc_No { get; set; }
        public string Ifsc_Code { get; set; }
        public string Pan_No { get; set; }
        public string Uan_No { get; set; }
        public string Ins_No { get; set; }
        public string Mediclaim { get; set; }
        public string Life_Ins { get; set; }
        public string Fam_PensionScheme { get; set; }
        public string Pf_No { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}