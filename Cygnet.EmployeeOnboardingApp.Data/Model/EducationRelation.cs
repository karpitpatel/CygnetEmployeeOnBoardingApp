using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class EducationRelation : BaseEntity
    {
        // public int Id{ get; set; }


        public string Degree { get; set; }
       
        public ICollection<EducationDetails> EducationDetails { get; set; }


    }
}
