namespace Aperture_Lab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addManager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Managers");
        }
    }
}
