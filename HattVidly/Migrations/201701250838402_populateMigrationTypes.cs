namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMigrationTypes : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
        }
        
        public override void Down()
        {
        }
    }
}
