namespace ForumApp.Infrasctructure.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludePost_Topic_User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200, unicode: false),
                        Content = c.String(),
                        Created = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        TopicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Topics", t => t.TopicId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.TopicId);
            
            CreateTable(
                "dbo.Topics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 200, unicode: false),
                        Created = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 100, unicode: false),
                        Password = c.String(maxLength: 100, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Posts", "TopicId", "dbo.Topics");
            DropForeignKey("dbo.Topics", "UserId", "dbo.Users");
            DropIndex("dbo.Topics", new[] { "UserId" });
            DropIndex("dbo.Posts", new[] { "TopicId" });
            DropIndex("dbo.Posts", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Topics");
            DropTable("dbo.Posts");
        }
    }
}
