namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_MembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes(Name) values('Pay as you go')");
            Sql("insert into MembershipTypes(Name) values('Monthly')");
            Sql("insert into MembershipTypes(Name) values('Annual')");
        }
        
        public override void Down()
        {
        }
    }
}
