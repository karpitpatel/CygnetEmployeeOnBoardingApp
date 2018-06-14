using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class VariousCardDetails : BaseEntity
    {
        public string Passport_No { get; set; }
        public string Passport_Validity { get; set; }
        public string Esic_No { get; set; }
        public string Vehicle_No { get; set; }
        public string Pension_Payment_OrderNo { get; set; }
        public string Scheme_Certificate_No { get; set; }

        public string Aadhar_No { get; set; }
        public string Election_No { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}