using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using Cygnet.EmployeeOnboardingApp.Data.Model;


namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IUserManager
    {
        List<UserViewModel> GetAllUsers();
        UserViewModel GetUser(string username);
        UserViewModel UserLogin(string username, string password);
        void IsRegister(UserViewModel user);
    }
    public class UserManager : BaseManager, IUserManager
    {
        private readonly IUserRepository _userRepository;
        private UserMapping userMapping;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            userMapping = new UserMapping();

        }
        public List<UserViewModel> GetAllUsers()
        {
            var dataModelList = _userRepository.GetUser();
            return userMapping.MapToViewList(dataModelList);

        }
        public UserViewModel GetUser(string username)
        {
            var dataModel = _userRepository.GetUser(username);
            return userMapping.MapToView(dataModel);

        }
        public UserViewModel UserLogin(string username, string password)
        {
            var data = _userRepository.UserLogin(username, password);
            return userMapping.MapToView(data);
        }
        public void IsRegister(UserViewModel userViewModel)
        {
            _userRepository.IsRegisterr(userMapping.MapToModel(userViewModel));
            _userRepository.UnitOfWork.Save();

        }
    }
}

