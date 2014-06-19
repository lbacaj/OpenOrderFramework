namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Title");
        }
    }
}
