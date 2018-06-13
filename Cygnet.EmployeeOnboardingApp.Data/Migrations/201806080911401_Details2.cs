namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EducationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EduId = c.Int(nullable: false),
                        School_College = c.String(),
                        Board_University = c.String(),
                        Year_Passing = c.String(),
                        Grade = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EducationRelation", t => t.EduId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.EduId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.EducationRelation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Degree = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EducationDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.EducationDetails", "EduId", "dbo.EducationRelation");
            DropIndex("dbo.EducationDetails", new[] { "UserId" });
            DropIndex("dbo.EducationDetails", new[] { "EduId" });
            DropTable("dbo.EducationRelation");
            DropTable("dbo.EducationDetails");
        }
    }
}
