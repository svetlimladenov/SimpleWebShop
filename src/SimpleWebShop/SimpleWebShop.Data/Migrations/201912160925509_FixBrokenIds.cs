namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixBrokenIds : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Orders", "ShipperId", "dbo.Shippers");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductImages", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropPrimaryKey("dbo.Addresses");
            DropPrimaryKey("dbo.OrderDetails");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Payments");
            DropPrimaryKey("dbo.Shippers");
            DropPrimaryKey("dbo.SupportMessages");
            DropPrimaryKey("dbo.Products");
            DropPrimaryKey("dbo.ProductCategories");
            DropPrimaryKey("dbo.ProductImages");
            AlterColumn("dbo.Addresses", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Orders", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Payments", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Shippers", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SupportMessages", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Products", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductCategories", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductImages", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Addresses", "Id");
            AddPrimaryKey("dbo.OrderDetails", new[] { "OrderId", "ProductId" });
            AddPrimaryKey("dbo.Orders", "Id");
            AddPrimaryKey("dbo.Payments", "Id");
            AddPrimaryKey("dbo.Shippers", "Id");
            AddPrimaryKey("dbo.SupportMessages", "Id");
            AddPrimaryKey("dbo.Products", "Id");
            AddPrimaryKey("dbo.ProductCategories", "Id");
            AddPrimaryKey("dbo.ProductImages", "Id");
            CreateIndex("dbo.OrderDetails", "OrderId");
            AddForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses", "Id");
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "PaymentId", "dbo.Payments", "Id");
            AddForeignKey("dbo.Orders", "ShipperId", "dbo.Shippers", "Id");
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductImages", "ProductId", "dbo.Products", "Id");
            AddForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.ProductImages", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "ShipperId", "dbo.Shippers");
            DropForeignKey("dbo.Orders", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropPrimaryKey("dbo.ProductImages");
            DropPrimaryKey("dbo.ProductCategories");
            DropPrimaryKey("dbo.Products");
            DropPrimaryKey("dbo.SupportMessages");
            DropPrimaryKey("dbo.Shippers");
            DropPrimaryKey("dbo.Payments");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.OrderDetails");
            DropPrimaryKey("dbo.Addresses");
            AlterColumn("dbo.ProductImages", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ProductCategories", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Products", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SupportMessages", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Shippers", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Payments", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Orders", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.OrderDetails", "OrderId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Addresses", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ProductImages", "Id");
            AddPrimaryKey("dbo.ProductCategories", "Id");
            AddPrimaryKey("dbo.Products", "Id");
            AddPrimaryKey("dbo.SupportMessages", "Id");
            AddPrimaryKey("dbo.Shippers", "Id");
            AddPrimaryKey("dbo.Payments", "Id");
            AddPrimaryKey("dbo.Orders", "Id");
            AddPrimaryKey("dbo.OrderDetails", new[] { "OrderId", "ProductId" });
            AddPrimaryKey("dbo.Addresses", "Id");
            CreateIndex("dbo.OrderDetails", "OrderId");
            AddForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories", "Id");
            AddForeignKey("dbo.ProductImages", "ProductId", "dbo.Products", "Id");
            AddForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "ShipperId", "dbo.Shippers", "Id");
            AddForeignKey("dbo.Orders", "PaymentId", "dbo.Payments", "Id");
            AddForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUsers", "AddressId", "dbo.Addresses", "Id");
        }
    }
}
