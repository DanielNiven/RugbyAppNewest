namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Results : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Home = c.String(),
                        VS = c.String(),
                        Away = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Results");
        }
    }
}
