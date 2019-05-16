namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Juniors : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ParentsDetails", "JuniorId", c => c.Int(nullable: false));
            AddColumn("dbo.ParentsDetails", "juniors_SruNumber", c => c.Int());
            CreateIndex("dbo.ParentsDetails", "juniors_SruNumber");
            AddForeignKey("dbo.ParentsDetails", "juniors_SruNumber", "dbo.JuniorsDetails", "SruNumber");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ParentsDetails", "juniors_SruNumber", "dbo.JuniorsDetails");
            DropIndex("dbo.ParentsDetails", new[] { "juniors_SruNumber" });
            DropColumn("dbo.ParentsDetails", "juniors_SruNumber");
            DropColumn("dbo.ParentsDetails", "JuniorId");
        }
    }
}
