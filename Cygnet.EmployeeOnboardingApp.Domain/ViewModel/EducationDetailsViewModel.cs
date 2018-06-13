using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
   public class EducationDetailsViewModel: BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public string EduId { get; set; }
        public string School_College { get; set; }
        public string Board_University { get; set; }
        public string Year_Passing { get; set; }
        public string Grade { get; set; }
       
        
    }
}
