using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class FamilyRelation : BaseEntity
    {
        // public int Id{ get; set; }

        public string Relationship { get; set; }

        public ICollection<FamilyDetails> FamilyDetails { get; set; }
    }
}