using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface INomineeDetailsManager
    {
        List<NomineeDetailsViewModel> GetAllNomineeDetails();
        NomineeDetailsViewModel GetNomineeDetails(int UserId);

        void IsRegister(NomineeDetailsViewModel nomineeDetailsViewModel);
      
        void IsUpdate(NomineeDetailsViewModel nomineeDetailsViewModel);
    }

    public class NomineeDetailsManager : BaseManager, INomineeDetailsManager
    {
        private readonly INomineeDetailsRepository _nomineeDetailsRepository;
        private NomineeDetailsMapping nomineeDetailsMapping;

        public NomineeDetailsManager(INomineeDetailsRepository nomineeDetailsRepository)
        {
            _nomineeDetailsRepository = nomineeDetailsRepository;
            nomineeDetailsMapping = new NomineeDetailsMapping();
        }

        public List<NomineeDetailsViewModel> GetAllNomineeDetails()
        {
            var dataModelList = _nomineeDetailsRepository.GetNomineeDetails();
            return nomineeDetailsMapping.MapToViewList(dataModelList);
        }

        public NomineeDetailsViewModel GetNomineeDetails(int UserId)
        {
            var dataModel = _nomineeDetailsRepository.GetNomineeDetails(UserId);
            return nomineeDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(NomineeDetailsViewModel nomineeDetailsViewModel)
        {
            _nomineeDetailsRepository.IsRegisterr(nomineeDetailsMapping.MapToModel(nomineeDetailsViewModel));
            _nomineeDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(NomineeDetailsViewModel nomineeDetailsViewModel)
        {
            _nomineeDetailsRepository.IsUpdatee(nomineeDetailsMapping.MapToModel(nomineeDetailsViewModel));
            _nomineeDetailsRepository.UnitOfWork.Save();
        }
    }
}