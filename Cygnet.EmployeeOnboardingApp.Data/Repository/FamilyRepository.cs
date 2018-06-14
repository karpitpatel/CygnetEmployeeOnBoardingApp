using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IFamilyRepository : IRepository<Family>
    {
        Family GetFamily(int Id);
        ICollection<Family> GetAllFamily(int UserId);
        ICollection<Family> GetFamily();
        void IsRegisterr(Family model);
        void IsUpdatee(Family model);

    }
    public class FamilyRepository : BaseRepository<Family>, IFamilyRepository
    {
        public FamilyRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public Family GetFamily(int Id)
        {
            return Get(_ => _.Id == Id).LastOrDefault();
        }

        public ICollection<Family> GetAllFamily(int UserId)
        {
            return Get(_ => _.UserId == UserId).ToList();
        }

        public ICollection<Family> GetFamily()
        {
            return Get().ToList();
        }


        public void IsRegisterr(Family model)
        {
            // if (model.Email != null && model.Password != null)
            //    return Update(model).ToList();
            Insert(model);
        }
        public void IsUpdatee(Family model)
        {
            Update(model);
        }


    }
}
