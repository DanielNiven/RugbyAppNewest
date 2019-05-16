namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Parents : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParentsDetails", "p1FName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParentsDetails", "p1FName", c => c.String());
        }
    }
}
