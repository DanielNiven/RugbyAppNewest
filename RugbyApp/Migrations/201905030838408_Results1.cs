namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Results1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TrainingRecords", "TrainingID", c => c.Int(nullable: false));
            CreateIndex("dbo.TrainingRecords", "TrainingID");
            AddForeignKey("dbo.TrainingRecords", "TrainingID", "dbo.TrainingRecords", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TrainingRecords", "TrainingID", "dbo.TrainingRecords");
            DropIndex("dbo.TrainingRecords", new[] { "TrainingID" });
            DropColumn("dbo.TrainingRecords", "TrainingID");
        }
    }
}
