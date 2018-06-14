namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using Cygnet.EmployeeOnboardingApp.Data.Model;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities";
        }

         protected override void Seed(Cygnet.EmployeeOnboardingApp.Data.Context.EmployeeOnBoardingEntities context)
          {
              //  This method will be called after migrating to the latest version.

              //  You can use the DbSet<T>.AddOrUpdate() helper extension method
              //  to avoid creating duplicate seed data.
          }
        


        
    }
}