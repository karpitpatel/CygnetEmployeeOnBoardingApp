namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Details3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Family",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Relation = c.String(),
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Family", "UserId", "dbo.User");
            DropIndex("dbo.Family", new[] { "UserId" });
            DropTable("dbo.Family");
        }
    }
}