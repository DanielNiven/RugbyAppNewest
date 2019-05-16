namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class training2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PassingStandard = c.Int(nullable: false),
                        PassingSpin = c.Int(nullable: false),
                        PassingPop = c.Int(nullable: false),
                        TacklingFront = c.Int(nullable: false),
                        TacklingRear = c.Int(nullable: false),
                        TacklingSide = c.Int(nullable: false),
                        TacklingScrum = c.Int(nullable: false),
                        KickDrop = c.Int(nullable: false),
                        KickGrubber = c.Int(nullable: false),
                        KickPunt = c.Int(nullable: false),
                        KickGoal = c.Int(nullable: false),
                        CommentBox = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainings");
        }
    }
}
