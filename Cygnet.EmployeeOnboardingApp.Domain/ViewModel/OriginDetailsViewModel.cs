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
  public class OriginDetailsViewModel:BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [DisplayName("Are you International Worker?")]
        public string Is_International_Worker { get; set; }
        [Required]
        [DisplayName("Country of Origin")]
        public string Country_Origin { get; set; }
    }
}
