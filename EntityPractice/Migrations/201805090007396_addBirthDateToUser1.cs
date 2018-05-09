namespace EntityPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthDateToUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "UpdatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "UpdatedAt");
        }
    }
}
