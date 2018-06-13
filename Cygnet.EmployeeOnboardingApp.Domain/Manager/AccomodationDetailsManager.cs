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
    public interface IAccomodationDetailsManager
    {
        List<AccomodationDetailsViewModel> GetAllAccomodationDetails();
        AccomodationDetailsViewModel GetAccomodationDetails(int EmpCode);
        void IsRegister(AccomodationDetailsViewModel accomodationDetailsViewModel);
        // void GetAccomodationDetails(int? id);
        void IsUpdate(AccomodationDetailsViewModel accomodationDetailsViewModel);
    }
    public class AccomodationDetailsManager : BaseManager, IAccomodationDetailsManager
    {
        private readonly IAccomodationDetailsRepository _accomodationDetailsRepository;
        private AccomodationDetailsMapping accomodationDetailsMapping;

        public AccomodationDetailsManager(IAccomodationDetailsRepository accomodationDetailsRepository)
        {
            _accomodationDetailsRepository = accomodationDetailsRepository;
            accomodationDetailsMapping = new AccomodationDetailsMapping();

        }
        public List<AccomodationDetailsViewModel> GetAllAccomodationDetails()
        {
            var dataModelList = _accomodationDetailsRepository.GetAccomodationDetails();
            return accomodationDetailsMapping.MapToViewList(dataModelList);

        }
        public AccomodationDetailsViewModel GetAccomodationDetails(int EmpCode)
        {
            var dataModel = _accomodationDetailsRepository.GetAccomodationDetails(EmpCode);
            return accomodationDetailsMapping.MapToView(dataModel);

        }
        public void IsRegister(AccomodationDetailsViewModel accomodationDetailsViewModel)
        {
            _accomodationDetailsRepository.IsRegisterr(accomodationDetailsMapping.MapToModel(accomodationDetailsViewModel));
            _accomodationDetailsRepository.UnitOfWork.Save();

        }
        public void IsUpdate(AccomodationDetailsViewModel accomodationDetailsViewModel)
        {
            _accomodationDetailsRepository.IsUpdatee(accomodationDetailsMapping.MapToModel(accomodationDetailsViewModel));
            _accomodationDetailsRepository.UnitOfWork.Save();

        }
    }
}

