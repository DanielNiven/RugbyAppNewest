namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeniorsU2D : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seniors",
                c => new
                    {
                        SruNumber = c.Int(nullable: false, identity: true),
                        FName = c.String(nullable: false),
                        LName = c.String(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.SruNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Seniors");
        }
    }
}
