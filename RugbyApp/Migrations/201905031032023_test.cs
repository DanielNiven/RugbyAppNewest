namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TrainingRecords", "TrainingID", "dbo.TrainingRecords");
            DropIndex("dbo.TrainingRecords", new[] { "TrainingID" });
            DropTable("dbo.TrainingRecords");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TrainingRecords",
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
                        TrainingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.TrainingRecords", "TrainingID");
            AddForeignKey("dbo.TrainingRecords", "TrainingID", "dbo.TrainingRecords", "ID");
        }
    }
}
