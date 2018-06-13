using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IVariousCardDetailsManager
    {
        List<VariousCardDetailsViewModel> GetAllVariousCardDetails();
        VariousCardDetailsViewModel GetVariousCardDetails(int EmpCode);
        void IsRegister(VariousCardDetailsViewModel variousCardDetailsViewModel);
        // void GetVariousCardDetails(int? id);
        void IsUpdate(VariousCardDetailsViewModel variousCardDetailsViewModel);
    }
    public class VariousCardDetailsManager : BaseManager, IVariousCardDetailsManager
    {
        private readonly IVariousCardDetailsRepository _variousCardDetailsRepository;
        private VariousCardDetailsMapping variousCardDetailsMapping;

        public VariousCardDetailsManager(IVariousCardDetailsRepository variousCardDetailsRepository)
        {
            _variousCardDetailsRepository = variousCardDetailsRepository;
            variousCardDetailsMapping = new VariousCardDetailsMapping();

        }
        public List<VariousCardDetailsViewModel> GetAllVariousCardDetails()
        {
            var dataModelList = _variousCardDetailsRepository.GetVariousCardDetails();
            return variousCardDetailsMapping.MapToViewList(dataModelList);

        }
        public VariousCardDetailsViewModel GetVariousCardDetails(int EmpCode)
        {
            var dataModel = _variousCardDetailsRepository.GetVariousCardDetails(EmpCode);
            return variousCardDetailsMapping.MapToView(dataModel);

        }
        public void IsRegister(VariousCardDetailsViewModel variousCardDetailsViewModel)
        {
            _variousCardDetailsRepository.IsRegisterr(variousCardDetailsMapping.MapToModel(variousCardDetailsViewModel));
            _variousCardDetailsRepository.UnitOfWork.Save();

        }
        public void IsUpdate(VariousCardDetailsViewModel variousCardDetailsViewModel)
        {
            _variousCardDetailsRepository.IsUpdatee(variousCardDetailsMapping.MapToModel(variousCardDetailsViewModel));
            _variousCardDetailsRepository.UnitOfWork.Save();

        }
    }
}

