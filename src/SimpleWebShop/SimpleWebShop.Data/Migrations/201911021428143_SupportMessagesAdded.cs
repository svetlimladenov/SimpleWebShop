namespace SimpleWebShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupportMessagesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupportMessages",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Content = c.String(),
                        UserId = c.String(maxLength: 128),
                        CreatedOn = c.DateTime(nullable: false),
                        ModifiedOn = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeletedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.IsDeleted);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupportMessages", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.SupportMessages", new[] { "IsDeleted" });
            DropIndex("dbo.SupportMessages", new[] { "UserId" });
            DropTable("dbo.SupportMessages");
        }
    }
}
