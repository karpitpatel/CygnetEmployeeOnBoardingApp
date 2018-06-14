namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FamilyDetails", "FamId", "dbo.FamilyRelation");
            DropForeignKey("dbo.FamilyDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.EducationDetails", "EduId", "dbo.EducationRelation");
            DropForeignKey("dbo.EducationDetails", "UserId", "dbo.User");
            DropIndex("dbo.FamilyDetails", new[] { "FamId" });
            DropIndex("dbo.FamilyDetails", new[] { "UserId" });
            DropIndex("dbo.EducationDetails", new[] { "EduId" });
            DropIndex("dbo.EducationDetails", new[] { "UserId" });
            DropTable("dbo.FamilyDetails");
            DropTable("dbo.FamilyRelation");
            DropTable("dbo.EducationDetails");
            DropTable("dbo.EducationRelation");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FamilyRelation",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Relationship = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FamilyDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamId = c.Int(nullable: false),
                        Name = c.String(),
                        Contact = c.String(),
                        Occupation = c.String(),
                        Dob = c.String(),
                        Aadhar_No = c.String(),
                        Residing_tog = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.EducationDetails", "UserId");
            CreateIndex("dbo.EducationDetails", "EduId");
            CreateIndex("dbo.FamilyDetails", "UserId");
            CreateIndex("dbo.FamilyDetails", "FamId");
            AddForeignKey("dbo.EducationDetails", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EducationDetails", "EduId", "dbo.EducationRelation", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FamilyDetails", "UserId", "dbo.User", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FamilyDetails", "FamId", "dbo.FamilyRelation", "Id", cascadeDelete: true);
        }
    }
}
