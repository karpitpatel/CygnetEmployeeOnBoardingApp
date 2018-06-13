using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class WorkingHistoryDetails : BaseEntity
    {  
       
       
        public string Name_Company { get; set; }
   
        public string Addr_Company { get; set; }
       
        public string Designation { get; set; }
      
        public string Department { get; set; }
      
       
        public string Designation_Person_ReportingTo { get; set; }
        public DateTime Doj { get; set; }
      
        public DateTime Dol { get; set; }
       
       
       public int Monthly_Gross_Salary { get; set; }
       public string Reason_For_Leaving { get; set; }
       public string Detailed_By {get;set;}
      
        public string Pension_No { get; set; }
      
        public string Reporting_To { get; set; }
      
        public string Ctc_Perannum { get; set; }
        public string Ref1_Name { get; set; }
        public string Ref1_Phn { get; set; }
        public string Ref1_Addr { get; set; }
        public string Ref2_Name { get; set; }
       
        public string Ref2_Phn { get; set; }
        public string Ref2_Addr { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }



    }
}

