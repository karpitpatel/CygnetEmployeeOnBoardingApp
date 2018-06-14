namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Details6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Education", "Year_Passing", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Education", "Year_Passing", c => c.String());
        }
    }
}