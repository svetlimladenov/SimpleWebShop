namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Idk : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropPrimaryKey("dbo.OrderDetails");
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.OrderDetails", new[] { "OrderId", "ProductId" });
            CreateIndex("dbo.OrderDetails", "OrderId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropPrimaryKey("dbo.OrderDetails");
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.OrderDetails", new[] { "OrderId", "ProductId" });
            CreateIndex("dbo.OrderDetails", "OrderId");
        }
    }
}
