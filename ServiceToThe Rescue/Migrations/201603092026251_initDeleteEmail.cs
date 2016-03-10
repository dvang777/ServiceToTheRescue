namespace ServiceToTheRescue.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDeleteEmail : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Technicians", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Technicians", "Email", c => c.String());
        }
    }
}
