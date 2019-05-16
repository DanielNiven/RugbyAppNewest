namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentsNew : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParentsDetails", "p1SName", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsDetails", "p1Relation", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsDetails", "p1Address", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsDetails", "p1PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsDetails", "p2Sname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParentsDetails", "p2Sname", c => c.String());
            AlterColumn("dbo.ParentsDetails", "p1PhoneNumber", c => c.String());
            AlterColumn("dbo.ParentsDetails", "p1Address", c => c.String());
            AlterColumn("dbo.ParentsDetails", "p1Relation", c => c.String());
            AlterColumn("dbo.ParentsDetails", "p1SName", c => c.String());
        }
    }
}
