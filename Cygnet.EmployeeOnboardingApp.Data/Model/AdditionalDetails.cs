using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class AdditionalDetails : BaseEntity
    {
        //   public int Id { get; set; }
      
        public string Rel_With_Present_Emp { get; set; }
        public string Name_Emp { get; set; }
        public string Relationship { get; set; }
        public string Details_If_Worked_Before { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
