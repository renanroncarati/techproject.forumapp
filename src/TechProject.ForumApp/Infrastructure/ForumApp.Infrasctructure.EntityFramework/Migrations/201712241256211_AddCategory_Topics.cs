namespace ForumApp.Infrasctructure.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory_Topics : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Topics", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Topics", "Category");
        }
    }
}
