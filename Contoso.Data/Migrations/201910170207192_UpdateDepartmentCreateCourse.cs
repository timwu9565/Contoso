namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDepartmentCreateCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Credits = c.Int(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Departments", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Departments", "CreateDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "CreateDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Departments", "CreatedDate");
            DropTable("dbo.Courses");
        }
    }
}
