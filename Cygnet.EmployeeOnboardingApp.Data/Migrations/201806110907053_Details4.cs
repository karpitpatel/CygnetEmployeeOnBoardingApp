namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Details4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PersonalDetails", "Dob", c => c.DateTime());
        }

        public override void Down()
        {
            AlterColumn("dbo.PersonalDetails", "Dob", c => c.DateTime(nullable: false));
        }
    }
}