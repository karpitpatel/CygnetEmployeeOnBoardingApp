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
   public class AdditionalDetailsViewModel:BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [DisplayName("Relationship with any Present Employee:")]

        public string Rel_With_Present_Emp { get; set; }
        [DisplayName("Name of the Employee:")]
        public string Name_Emp { get; set; }
        [DisplayName("Relationship with Present Employee:")]
        public string Relationship { get; set; }
        [DisplayName("Details If you have worked before:")]
        public string Details_If_Worked_Before { get; set; }
    }
}
