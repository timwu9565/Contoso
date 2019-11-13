namespace Contoso.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInstructorAndStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "HireDate", c => c.DateTime());
            AddColumn("dbo.People", "EnrollmentDate", c => c.DateTime());
            AddColumn("dbo.People", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Discriminator");
            DropColumn("dbo.People", "EnrollmentDate");
            DropColumn("dbo.People", "HireDate");
        }
    }
}
