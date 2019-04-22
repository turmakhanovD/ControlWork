namespace NomadApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscriptionTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SubType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "SubscriptionId", c => c.Guid(nullable: false));
            DropColumn("dbo.Users", "SubscriptionType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "SubscriptionType", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "SubscriptionId");
            DropTable("dbo.SubscriptionTypes");
        }
    }
}
