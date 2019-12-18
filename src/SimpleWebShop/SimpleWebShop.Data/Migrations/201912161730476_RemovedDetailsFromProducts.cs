namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedDetailsFromProducts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            DropColumn("dbo.Products", "ShortDescription");
            DropColumn("dbo.Products", "LongDescription");
            DropColumn("dbo.Products", "Details");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Details", c => c.String());
            AddColumn("dbo.Products", "LongDescription", c => c.String());
            AddColumn("dbo.Products", "ShortDescription", c => c.String());
            DropColumn("dbo.Products", "Description");
        }
    }
}
