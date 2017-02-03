namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate : DbMigration
    {
        public override void Up()
        {

            Sql("insert into MembershipTypes(Name, SignUpFee, DurationInMonths, DiscountRate) values('Pay as you go', 200, 1, 0)");
            Sql("insert into MembershipTypes(Name, SignUpFee, DurationInMonths, DiscountRate) values('Monthly', 100, 1, 5)");
            Sql("insert into MembershipTypes(Name, SignUpFee, DurationInMonths, DiscountRate) values('Quarterly', 70, 3, 10)");
            Sql("insert into MembershipTypes(Name, SignUpFee, DurationInMonths, DiscountRate) values('Annual', 0, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
