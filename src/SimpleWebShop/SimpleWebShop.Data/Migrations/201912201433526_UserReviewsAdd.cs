namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserReviewsAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductUserReviews",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Starts = c.Int(nullable: false),
                        Review = c.String(),
                        Title = c.String(),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.ProductId, t.UserId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId)
                .Index(t => t.IsDeleted);
            
            AddColumn("dbo.OrderDetails", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.OrderDetails", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.OrderDetails", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderDetails", "DeletedOn", c => c.DateTime());
            CreateIndex("dbo.OrderDetails", "IsDeleted");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductUserReviews", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ProductUserReviews", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductUserReviews", new[] { "IsDeleted" });
            DropIndex("dbo.ProductUserReviews", new[] { "UserId" });
            DropIndex("dbo.ProductUserReviews", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "IsDeleted" });
            DropColumn("dbo.OrderDetails", "DeletedOn");
            DropColumn("dbo.OrderDetails", "IsDeleted");
            DropColumn("dbo.OrderDetails", "ModifiedOn");
            DropColumn("dbo.OrderDetails", "CreatedOn");
            DropTable("dbo.ProductUserReviews");
        }
    }
}
