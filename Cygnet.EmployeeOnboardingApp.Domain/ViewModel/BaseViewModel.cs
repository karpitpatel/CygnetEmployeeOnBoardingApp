using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class BaseViewModel
    {
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
        [ReadOnly(true)]
        public DateTime Created { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
        [ReadOnly(true)]
        public DateTime Modified { get; set; }
    }
}