using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IOriginDetailsManager
    {
        List<OriginDetailsViewModel> GetAllOriginDetails();

        OriginDetailsViewModel GetOriginDetails(int EmpCode);

        void IsRegister(OriginDetailsViewModel originDetailsViewModel);

        // void GetOriginDetails(int? id);
        void IsUpdate(OriginDetailsViewModel originDetailsViewModel);
    }

    public class OriginDetailsManager : BaseManager, IOriginDetailsManager
    {
        private readonly IOriginDetailsRepository _originDetailsRepository;
        private OriginDetailsMapping originDetailsMapping;

        public OriginDetailsManager(IOriginDetailsRepository originDetailsRepository)
        {
            _originDetailsRepository = originDetailsRepository;
            originDetailsMapping = new OriginDetailsMapping();
        }

        public List<OriginDetailsViewModel> GetAllOriginDetails()
        {
            var dataModelList = _originDetailsRepository.GetOriginDetails();
            return originDetailsMapping.MapToViewList(dataModelList);
        }

        public OriginDetailsViewModel GetOriginDetails(int EmpCode)
        {
            var dataModel = _originDetailsRepository.GetOriginDetails(EmpCode);
            return originDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(OriginDetailsViewModel originDetailsViewModel)
        {
            _originDetailsRepository.IsRegisterr(originDetailsMapping.MapToModel(originDetailsViewModel));
            _originDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(OriginDetailsViewModel originDetailsViewModel)
        {
            _originDetailsRepository.IsUpdatee(originDetailsMapping.MapToModel(originDetailsViewModel));
            _originDetailsRepository.UnitOfWork.Save();
        }
    }
}