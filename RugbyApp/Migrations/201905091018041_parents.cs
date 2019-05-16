namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class parents : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParentsDetails", "p1FName", c => c.String(nullable: false));
            AlterColumn("dbo.ParentsDetails", "p1SName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParentsDetails", "p1SName", c => c.String());
            AlterColumn("dbo.ParentsDetails", "p1FName", c => c.String());
        }
    }
}
