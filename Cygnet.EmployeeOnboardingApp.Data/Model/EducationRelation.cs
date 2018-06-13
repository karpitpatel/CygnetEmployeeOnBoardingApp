using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class EducationRelation : BaseEntity
    {
        // public int Id{ get; set; }

        public string Degree { get; set; }

        public ICollection<EducationDetails> EducationDetails { get; set; }
    }
}