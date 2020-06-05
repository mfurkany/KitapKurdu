namespace KitapKurdu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Name");
        }
    }
}
