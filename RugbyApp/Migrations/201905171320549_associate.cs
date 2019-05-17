namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class associate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JuniorsDetails", "ParentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.JuniorsDetails", "ParentId");
        }
    }
}
