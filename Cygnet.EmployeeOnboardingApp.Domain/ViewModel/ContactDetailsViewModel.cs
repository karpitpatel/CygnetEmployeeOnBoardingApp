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
    public class ContactDetailsViewModel : BaseViewModel
    {  
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [DisplayName("Personal Email ID")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Home Contact Number")]
        public int HomeNo { get; set; }
        [Required]
        [DisplayName("Mobile Number")]
        public int MobNo { get; set; }
        [Required]
        [DisplayName("Temporary Address")]
        public string TempAddr { get; set; }
        [Required]
        [DisplayName("Pincode")]
        public int Pincode_tempaddr { get; set; }
        [Required]
        [DisplayName("Pemanent Address")]
        public string PermAddr { get; set; }
       
        [Required]
        [DisplayName("Pincode")]
        public int Pincode_permadrr { get; set; }
    }
}
