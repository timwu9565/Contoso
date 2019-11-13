namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationshipForAll : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.OfficeAssignments");
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.OfficeAssignments", "InstructorId");
            CreateIndex("dbo.Courses", "DepartmentID");
            CreateIndex("dbo.Departments", "InstructorId");
            CreateIndex("dbo.Enrollments", "CourseId");
            CreateIndex("dbo.Enrollments", "StudentId");
            CreateIndex("dbo.OfficeAssignments", "InstructorId");
            AddForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor", "Id");
            AddForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Enrollments", "StudentId", "dbo.Student", "Id");
            AddForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructor", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OfficeAssignments", "InstructorId", "dbo.Instructor");
            DropForeignKey("dbo.Enrollments", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Enrollments", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Departments", "InstructorId", "dbo.Instructor");
            DropForeignKey("dbo.Courses", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.OfficeAssignments", new[] { "InstructorId" });
            DropIndex("dbo.Enrollments", new[] { "StudentId" });
            DropIndex("dbo.Enrollments", new[] { "CourseId" });
            DropIndex("dbo.Departments", new[] { "InstructorId" });
            DropIndex("dbo.Courses", new[] { "DepartmentID" });
            DropPrimaryKey("dbo.OfficeAssignments");
            AlterColumn("dbo.OfficeAssignments", "InstructorId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.OfficeAssignments", "InstructorId");
        }
    }
}
