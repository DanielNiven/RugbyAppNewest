namespace RugbyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TrainingNew : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Trainings", newName: "TrainingRecords");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TrainingRecords", newName: "Trainings");
        }
    }
}
