namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class currentv88 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Experation", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Experation", c => c.DateTime());
        }
    }
}
