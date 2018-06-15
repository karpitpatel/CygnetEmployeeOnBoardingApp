namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PersonalDetails", "Date_Anniv", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PersonalDetails", "Date_Anniv", c => c.DateTime(nullable: false));
        }
    }
}
