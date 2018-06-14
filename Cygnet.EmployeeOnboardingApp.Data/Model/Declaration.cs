using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class Declaration : BaseEntity
    {
        public string Kyc_Details { get; set; }
        public string Is_Mem_Epf_Schema { get; set; }
        public DateTime Dt_Allot_Ins_No { get; set; }
        public DateTime Dt_Issue_Tic { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}