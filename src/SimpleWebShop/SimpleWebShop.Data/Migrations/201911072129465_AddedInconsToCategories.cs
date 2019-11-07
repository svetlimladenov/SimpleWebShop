namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInconsToCategories : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductCategories", "IconClass", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductCategories", "IconClass");
        }
    }
}
