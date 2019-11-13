namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentAndInstructor : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Instructor");
            DropPrimaryKey("dbo.Instructor");
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        DateofBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        UnitOrApartmentNumber = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Password = c.String(),
                        Salt = c.String(),
                        Islocked = c.Boolean(nullable: false),
                        LastLockedDateTime = c.DateTime(nullable: false),
                        FailedAttempts = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Instructor", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Instructor", "HireDate", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Instructor", "Id");
            CreateIndex("dbo.Instructor", "Id");
            AddForeignKey("dbo.Instructor", "Id", "dbo.People", "Id");
            DropColumn("dbo.Instructor", "LastName");
            DropColumn("dbo.Instructor", "FirstName");
            DropColumn("dbo.Instructor", "MiddleName");
            DropColumn("dbo.Instructor", "DateofBirth");
            DropColumn("dbo.Instructor", "Email");
            DropColumn("dbo.Instructor", "Phone");
            DropColumn("dbo.Instructor", "AddressLine1");
            DropColumn("dbo.Instructor", "AddressLine2");
            DropColumn("dbo.Instructor", "UnitOrApartmentNumber");
            DropColumn("dbo.Instructor", "City");
            DropColumn("dbo.Instructor", "State");
            DropColumn("dbo.Instructor", "ZipCode");
            DropColumn("dbo.Instructor", "Password");
            DropColumn("dbo.Instructor", "Salt");
            DropColumn("dbo.Instructor", "Islocked");
            DropColumn("dbo.Instructor", "LastLockedDateTime");
            DropColumn("dbo.Instructor", "FailedAttempts");
            DropColumn("dbo.Instructor", "CreatedDate");
            DropColumn("dbo.Instructor", "CreatedBy");
            DropColumn("dbo.Instructor", "UpdatedDate");
            DropColumn("dbo.Instructor", "UpdatedBy");
            DropColumn("dbo.Instructor", "EnrollmentDate");
            DropColumn("dbo.Instructor", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructor", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Instructor", "EnrollmentDate", c => c.DateTime());
            AddColumn("dbo.Instructor", "UpdatedBy", c => c.String());
            AddColumn("dbo.Instructor", "UpdatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Instructor", "CreatedBy", c => c.String());
            AddColumn("dbo.Instructor", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Instructor", "FailedAttempts", c => c.Int(nullable: false));
            AddColumn("dbo.Instructor", "LastLockedDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Instructor", "Islocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.Instructor", "Salt", c => c.String());
            AddColumn("dbo.Instructor", "Password", c => c.String());
            AddColumn("dbo.Instructor", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Instructor", "State", c => c.String());
            AddColumn("dbo.Instructor", "City", c => c.String());
            AddColumn("dbo.Instructor", "UnitOrApartmentNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Instructor", "AddressLine2", c => c.String());
            AddColumn("dbo.Instructor", "AddressLine1", c => c.String());
            AddColumn("dbo.Instructor", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.Instructor", "Email", c => c.String());
            AddColumn("dbo.Instructor", "DateofBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Instructor", "MiddleName", c => c.String());
            AddColumn("dbo.Instructor", "FirstName", c => c.String());
            AddColumn("dbo.Instructor", "LastName", c => c.String());
            DropForeignKey("dbo.Student", "Id", "dbo.People");
            DropForeignKey("dbo.Instructor", "Id", "dbo.People");
            DropIndex("dbo.Student", new[] { "Id" });
            DropIndex("dbo.Instructor", new[] { "Id" });
            DropPrimaryKey("dbo.Instructor");
            AlterColumn("dbo.Instructor", "HireDate", c => c.DateTime());
            AlterColumn("dbo.Instructor", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Student");
            DropTable("dbo.People");
            AddPrimaryKey("dbo.Instructor", "Id");
            RenameTable(name: "dbo.Instructor", newName: "People");
        }
    }
}
