namespace Aperture_Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationship : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "Manager_ID", c => c.Int());
            CreateIndex("dbo.Participants", "Manager_ID");
            AddForeignKey("dbo.Participants", "Manager_ID", "dbo.Managers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Participants", "Manager_ID", "dbo.Managers");
            DropIndex("dbo.Participants", new[] { "Manager_ID" });
            DropColumn("dbo.Participants", "Manager_ID");
        }
    }
}
