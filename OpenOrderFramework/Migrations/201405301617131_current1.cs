namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class current1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Experation", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Experation");
        }
    }
}
