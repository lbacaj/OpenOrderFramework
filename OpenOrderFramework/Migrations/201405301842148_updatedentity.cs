namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "SaveInfo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "SaveInfo");
        }
    }
}
