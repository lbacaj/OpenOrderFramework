namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v70 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Email", c => c.String(nullable: false));
        }
    }
}
