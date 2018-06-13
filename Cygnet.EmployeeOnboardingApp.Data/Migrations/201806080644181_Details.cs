namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FamilyRelation", "FamilyRelation_Id", "dbo.FamilyRelation");
            DropIndex("dbo.FamilyRelation", new[] { "FamilyRelation_Id" });
            DropColumn("dbo.FamilyRelation", "FamilyRelation_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FamilyRelation", "FamilyRelation_Id", c => c.Int());
            CreateIndex("dbo.FamilyRelation", "FamilyRelation_Id");
            AddForeignKey("dbo.FamilyRelation", "FamilyRelation_Id", "dbo.FamilyRelation", "Id");
        }
    }
}
