namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BugFixes : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.OrderDetails", newName: "OrderProducts");
            RenameTable(name: "dbo.ProductUserReviews", newName: "UserProductReviews");
            AddColumn("dbo.UserProductReviews", "Stars", c => c.Int(nullable: false));
            DropColumn("dbo.UserProductReviews", "Starts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProductReviews", "Starts", c => c.Int(nullable: false));
            DropColumn("dbo.UserProductReviews", "Stars");
            RenameTable(name: "dbo.UserProductReviews", newName: "ProductUserReviews");
            RenameTable(name: "dbo.OrderProducts", newName: "OrderDetails");
        }
    }
}
