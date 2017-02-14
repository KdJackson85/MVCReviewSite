namespace MVC_Review_Site_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenreTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Artist = c.String(),
                        Album = c.String(),
                        AlbumReview = c.String(),
                        Rating = c.Double(nullable: false),
                        GenreID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GenreTypes", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "GenreID", "dbo.GenreTypes");
            DropIndex("dbo.Reviews", new[] { "GenreID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.GenreTypes");
        }
    }
}
