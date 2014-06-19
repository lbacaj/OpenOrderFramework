namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vCurrent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "InternalImage", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "InternalImage");
        }
    }
}
