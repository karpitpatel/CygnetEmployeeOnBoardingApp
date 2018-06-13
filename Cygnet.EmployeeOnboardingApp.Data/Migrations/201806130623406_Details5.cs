namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Education",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        School_College = c.String(),
                        Board_University = c.String(),
                        Degree = c.String(),
                        Year_Passing = c.String(),
                        Grade = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Education", "UserId", "dbo.User");
            DropIndex("dbo.Education", new[] { "UserId" });
            DropTable("dbo.Education");
        }
    }
}
