using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IEducationRepository : IRepository<Education>
    {
        Education GetEducation(int Id);
        ICollection<Education> GetAllEducation(int UserId);
        ICollection<Education> GetEducation();
        void IsRegisterr(Education model);
        void IsUpdatee(Education model);

    }
    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        public EducationRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public Education GetEducation(int Id)
        {
            return Get(_ => _.Id == Id).LastOrDefault();
        }

        public ICollection<Education> GetAllEducation(int UserId)
        {
            return Get(_ => _.UserId == UserId).ToList();
        }

        public ICollection<Education> GetEducation()
        {
            return Get().ToList();
        }


        public void IsRegisterr(Education model)
        {
            
            Insert(model);
        }
        public void IsUpdatee(Education model)
        {
            Update(model);
        }


    }
}
