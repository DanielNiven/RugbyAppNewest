namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trainingold : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        KickDrop = c.Int(nullable: false),
                        PassStandard = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainings");
        }
    }
}
