namespace NomadApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubscriptionTypes", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubscriptionTypes", "Price");
        }
    }
}
