namespace MVC_Review_Site_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuickReview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "QuickReview", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "QuickReview");
        }
    }
}
