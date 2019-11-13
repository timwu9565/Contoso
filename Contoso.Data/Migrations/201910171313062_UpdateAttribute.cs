namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Title", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Courses", "CreatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.Courses", "UpdatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Departments", "CreatedBy", c => c.String(maxLength: 10));
            AlterColumn("dbo.Departments", "UpdatedBy", c => c.String(maxLength: 10));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.People", "Email", c => c.String(maxLength: 30));
            AlterColumn("dbo.People", "AddressLine1", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "AddressLine2", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "City", c => c.String(maxLength: 15));
            AlterColumn("dbo.People", "State", c => c.String(maxLength: 15));
            AlterColumn("dbo.People", "Password", c => c.String(maxLength: 20));
            AlterColumn("dbo.People", "CreatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.People", "UpdatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.OfficeAssignments", "Location", c => c.String(maxLength: 10));
            AlterColumn("dbo.OfficeAssignments", "CreatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.OfficeAssignments", "UpdatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.Roles", "RoleName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Roles", "Description", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Roles", "CreatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.Roles", "UpdatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.Enrollments", "CreatedBy", c => c.String(maxLength: 20));
            AlterColumn("dbo.Enrollments", "UpdatedBy", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Enrollments", "CreatedBy", c => c.String());
            AlterColumn("dbo.Roles", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Roles", "CreatedBy", c => c.String());
            AlterColumn("dbo.Roles", "Description", c => c.String());
            AlterColumn("dbo.Roles", "RoleName", c => c.String());
            AlterColumn("dbo.OfficeAssignments", "UpdatedBy", c => c.String());
            AlterColumn("dbo.OfficeAssignments", "CreatedBy", c => c.String());
            AlterColumn("dbo.OfficeAssignments", "Location", c => c.String(maxLength: 150));
            AlterColumn("dbo.People", "UpdatedBy", c => c.String());
            AlterColumn("dbo.People", "CreatedBy", c => c.String());
            AlterColumn("dbo.People", "Password", c => c.String());
            AlterColumn("dbo.People", "State", c => c.String());
            AlterColumn("dbo.People", "City", c => c.String());
            AlterColumn("dbo.People", "AddressLine2", c => c.String());
            AlterColumn("dbo.People", "AddressLine1", c => c.String());
            AlterColumn("dbo.People", "Email", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.Departments", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Departments", "CreatedBy", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.Courses", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Courses", "CreatedBy", c => c.String());
            AlterColumn("dbo.Courses", "Title", c => c.String());
        }
    }
}
