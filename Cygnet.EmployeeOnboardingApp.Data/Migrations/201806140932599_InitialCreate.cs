namespace Cygnet.EmployeeOnboardingApp.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccomodationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rent_Ownership = c.String(),
                        Owner_Name = c.String(),
                        Owner_Contact = c.String(),
                        Owner_Addr = c.String(),
                        Owner_Occupation = c.String(),
                        Neigh1_Name = c.String(),
                        Neigh1_Contact = c.String(),
                        Neigh1_Occupation = c.String(),
                        Neigh2_Name = c.String(),
                        Neigh2_Contact = c.String(),
                        Neigh2_Occupation = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdditionalDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rel_With_Present_Emp = c.String(),
                        Name_Emp = c.String(),
                        Relationship = c.String(),
                        Details_If_Worked_Before = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.BankDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acc_No = c.String(),
                        Ifsc_Code = c.String(),
                        Pan_No = c.String(),
                        Uan_No = c.String(),
                        Ins_No = c.String(),
                        Mediclaim = c.String(),
                        Life_Ins = c.String(),
                        Fam_PensionScheme = c.String(),
                        Pf_No = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ContactDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        HomeNo = c.String(),
                        MobNo = c.String(),
                        TempAddr = c.String(),
                        PermAddr = c.String(),
                        Pincode_tempaddr = c.String(),
                        Pincode_permadrr = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Declaration",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Kyc_Details = c.String(),
                        Is_Mem_Epf_Schema = c.String(),
                        Dt_Allot_Ins_No = c.DateTime(nullable: false),
                        Dt_Issue_Tic = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Education",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        School_College = c.String(),
                        Board_University = c.String(),
                        Degree = c.String(),
                        Year_Passing = c.Int(nullable: false),
                        Grade = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Family",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Relation = c.String(),
                        Contact = c.String(),
                        Occupation = c.String(),
                        Dob = c.DateTime(nullable: false),
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
            
            CreateTable(
                "dbo.NomineeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Relationship = c.String(),
                        Address = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.OriginDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Is_International_Worker = c.String(),
                        Country_Origin = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.PersonalDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Father_Name = c.String(),
                        Sex = c.String(),
                        Marital_Stat = c.String(),
                        Date_Anniv = c.String(),
                        Dob = c.DateTime(nullable: false),
                        Name_Company = c.String(),
                        Designation = c.String(),
                        Department = c.String(),
                        Blood_Grp = c.String(),
                        Allergy = c.String(),
                        Ailment = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.VariousCaredDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Passport_No = c.String(),
                        Passport_Validity = c.DateTime(nullable: false),
                        Esic_No = c.String(),
                        Vehicle_No = c.String(),
                        Pension_Payment_OrderNo = c.String(),
                        Scheme_Certificate_No = c.String(),
                        Aadhar_No = c.String(),
                        Election_No = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WorkingHistoryDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_Company = c.String(),
                        Addr_Company = c.String(),
                        Designation = c.String(),
                        Department = c.String(),
                        Designation_Person_ReportingTo = c.String(),
                        Doj = c.DateTime(nullable: false),
                        Dol = c.DateTime(nullable: false),
                        Monthly_Gross_Salary = c.Int(nullable: false),
                        Reason_For_Leaving = c.String(),
                        Detailed_By = c.String(),
                        Pension_No = c.String(),
                        Reporting_To = c.String(),
                        Ctc_Perannum = c.String(),
                        Ref1_Name = c.String(),
                        Ref1_Phn = c.String(),
                        Ref1_Addr = c.String(),
                        Ref2_Name = c.String(),
                        Ref2_Phn = c.String(),
                        Ref2_Addr = c.String(),
                        UserId = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.TestUOW",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkingHistoryDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.VariousCaredDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.PersonalDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.OriginDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.NomineeDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.Family", "UserId", "dbo.User");
            DropForeignKey("dbo.Education", "UserId", "dbo.User");
            DropForeignKey("dbo.Declaration", "UserId", "dbo.User");
            DropForeignKey("dbo.ContactDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.BankDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.AdditionalDetails", "UserId", "dbo.User");
            DropForeignKey("dbo.AccomodationDetails", "UserId", "dbo.User");
            DropIndex("dbo.WorkingHistoryDetails", new[] { "UserId" });
            DropIndex("dbo.VariousCaredDetails", new[] { "UserId" });
            DropIndex("dbo.PersonalDetails", new[] { "UserId" });
            DropIndex("dbo.OriginDetails", new[] { "UserId" });
            DropIndex("dbo.NomineeDetails", new[] { "UserId" });
            DropIndex("dbo.Family", new[] { "UserId" });
            DropIndex("dbo.Education", new[] { "UserId" });
            DropIndex("dbo.Declaration", new[] { "UserId" });
            DropIndex("dbo.ContactDetails", new[] { "UserId" });
            DropIndex("dbo.BankDetails", new[] { "UserId" });
            DropIndex("dbo.AdditionalDetails", new[] { "UserId" });
            DropIndex("dbo.AccomodationDetails", new[] { "UserId" });
            DropTable("dbo.TestUOW");
            DropTable("dbo.WorkingHistoryDetails");
            DropTable("dbo.VariousCaredDetails");
            DropTable("dbo.PersonalDetails");
            DropTable("dbo.OriginDetails");
            DropTable("dbo.NomineeDetails");
            DropTable("dbo.Family");
            DropTable("dbo.Education");
            DropTable("dbo.Declaration");
            DropTable("dbo.ContactDetails");
            DropTable("dbo.BankDetails");
            DropTable("dbo.AdditionalDetails");
            DropTable("dbo.User");
            DropTable("dbo.AccomodationDetails");
        }
    }
}
