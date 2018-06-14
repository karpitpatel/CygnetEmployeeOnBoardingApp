using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class User : BaseEntity
    { 

        public string Name { get; set; }

      
        public string Email { get; set; }
   
        public string Password { get; set; }

        public ICollection<PersonalDetails> PersonalDetails { get; set; }
        public ICollection<ContactDetails> ContactDetails { get; set; }
        public ICollection<AccomodationDetails> AccomodationDetails { get; set; }
        public ICollection<AdditionalDetails> AdditionalDetails { get; set; }
        public ICollection<BankDetails> BankDetails { get; set; }
 
        public ICollection<Family> Family { get; set; }
        public ICollection<Education> Education{ get; set; }
        public ICollection<Declaration> Declaration { get; set; }
        public ICollection<NomineeDetails> NomineeDetails { get; set; }
        public ICollection<OriginDetails> OriginDetails { get; set; }
        public ICollection<VariousCardDetails> VariousCardDetails { get; set; }
        public ICollection<WorkingHistoryDetails> WorkingHistoryDetails { get; set; }





    }
}
