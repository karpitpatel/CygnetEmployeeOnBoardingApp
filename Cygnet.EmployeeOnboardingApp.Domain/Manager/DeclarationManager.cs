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
    public interface IDeclarationManager
    {
        List<DeclarationViewModel> GetAllDeclaration();
        DeclarationViewModel GetDeclaration(int UserId);
        void IsRegister(DeclarationViewModel declarationViewModel);
       
        void IsUpdate(DeclarationViewModel declarationViewModel);
    }
    public class DeclarationManager : BaseManager, IDeclarationManager
    {
        private readonly IDeclarationRepository _declarationRepository;
        private DeclarationMapping declarationMapping;

        public DeclarationManager(IDeclarationRepository declarationRepository)
        {
            _declarationRepository = declarationRepository;
            declarationMapping = new DeclarationMapping();

        }
        public List<DeclarationViewModel> GetAllDeclaration()
        {
            var dataModelList = _declarationRepository.GetDeclaration();
            return declarationMapping.MapToViewList(dataModelList);

        }
        public DeclarationViewModel GetDeclaration(int UserId)
        {
            var dataModel = _declarationRepository.GetDeclaration(UserId);
            return declarationMapping.MapToView(dataModel);

        }
        public void IsRegister(DeclarationViewModel declarationViewModel)
        {
            _declarationRepository.IsRegisterr(declarationMapping.MapToModel(declarationViewModel));
            _declarationRepository.UnitOfWork.Save();

        }
        public void IsUpdate(DeclarationViewModel declarationViewModel)
        {
            _declarationRepository.IsUpdatee(declarationMapping.MapToModel(declarationViewModel));
            _declarationRepository.UnitOfWork.Save();

        }
    }
}

