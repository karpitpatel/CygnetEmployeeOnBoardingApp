namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactDetails", "AlternateNo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactDetails", "AlternateNo");
        }
    }
}
