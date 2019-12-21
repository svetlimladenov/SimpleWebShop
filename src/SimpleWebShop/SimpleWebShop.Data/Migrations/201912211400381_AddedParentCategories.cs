namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedParentCategories : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductCategories", newName: "Categories");
            RenameColumn(table: "dbo.Products", name: "ProductCategoryId", newName: "CategoryId");
            RenameIndex(table: "dbo.Products", name: "IX_ProductCategoryId", newName: "IX_CategoryId");
            AddColumn("dbo.Categories", "ParentCategoryId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Categories", "ParentCategoryId");
            AddForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ParentCategoryId", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "ParentCategoryId" });
            DropColumn("dbo.Categories", "ParentCategoryId");
            RenameIndex(table: "dbo.Products", name: "IX_CategoryId", newName: "IX_ProductCategoryId");
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "ProductCategoryId");
            RenameTable(name: "dbo.Categories", newName: "ProductCategories");
        }
    }
}
