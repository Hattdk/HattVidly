namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_entity_and_context : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
