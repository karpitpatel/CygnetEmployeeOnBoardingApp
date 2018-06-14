using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IUserRepository : IRepository<User>
    {
      User GetUser(string Email);
        ICollection<User> GetUser();
       User UserLogin(string userName, string password);
      void IsRegisterr(User model);

    }
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public User GetUser(string username)
        {
            return Get(_ => _.Email == username).FirstOrDefault();
        }

        public ICollection<User> GetUser()
        {
            return Get().ToList();
        }

        public User UserLogin(string userName, string password)
        {
           

            return Get(_ => _.Email == userName && _.Password == password).ToList().FirstOrDefault();



        }
        public void IsRegisterr(User model)
        {
           
            Insert(model);
        }

       
    }
}
