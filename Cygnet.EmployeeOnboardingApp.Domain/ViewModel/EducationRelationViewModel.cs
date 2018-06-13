using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
   public class EducationRelationViewModel:BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public string Degree { get; set; }


    }
}
