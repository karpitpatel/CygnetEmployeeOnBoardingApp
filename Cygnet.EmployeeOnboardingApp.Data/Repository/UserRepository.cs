using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUser(string Email);

        ICollection<User> GetUser();

        User UserLogin(string userName, string password);

        void Isfieldd(User model);
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
            /* User user = Get(_ => _.Email == userName && _.Password == password).ToList().FirstOrDefault();*/

            return Get(_ => _.Email == userName && _.Password == password).ToList().FirstOrDefault();

            /* if (user != null)
                 return true;
             else
                 return false;*/
        }

        public void Isfieldd(User model)
        {
            // if (model.Email != null && model.Password != null)
            //    return Update(model).ToList();
            Insert(model);
        }
    }
}