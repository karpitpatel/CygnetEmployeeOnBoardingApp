namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using Cygnet.EmployeeOnboardingApp.Data.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities";
        }

        /*  protected override void Seed(Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities context)
          {
              //  This method will be called after migrating to the latest version.

              //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
              //  to avoid creating duplicate seed data.
          }*/
        protected override void Seed(Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities context)
        {
            context.FamilyRelation.AddOrUpdate(x => x.Id,
                new FamilyRelation() { Id = 1, Relationship = "Father" },
                new FamilyRelation() { Id = 2, Relationship = "Mother" },
                new FamilyRelation() { Id = 3, Relationship = "Sibling" },
                new FamilyRelation() { Id = 4, Relationship = "Spouse" },
                new FamilyRelation() { Id = 5, Relationship = "Children" }

                );
            context.SaveChanges();
            context.EducationRelation.AddOrUpdate(x => x.Id,
                new EducationRelation() { Id = 1, Degree = "10th" },
                new EducationRelation() { Id = 2, Degree = "12th" },
                new EducationRelation() { Id = 3, Degree = "Bachelors" },
                new EducationRelation() { Id = 4, Degree = "Masters" },
                new EducationRelation() { Id = 5, Degree = "Others" }

                );
            context.SaveChanges();


        }
        
    }
}
