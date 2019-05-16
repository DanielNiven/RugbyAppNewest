namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Details : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JuniorsDetails", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.JuniorsDetails", "Position");
        }
    }
}
