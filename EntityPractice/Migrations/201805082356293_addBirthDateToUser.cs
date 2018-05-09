namespace EntityPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthDateToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Birthdate");
        }
    }
}
