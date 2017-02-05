namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_customers_correct : DbMigration
    {
        public override void Up()
        {

            //Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipType_Id, BirthDate) values('Samantha', '1', '1', '01/01/1998')");
            //Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipType_Id, BirthDate) values('Beth', '0', '2', '10/12/1995')");
            //Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipType_Id, BirthDate) values('Yvonne', '0', '3', '7/4/2000')");
        }
        
        public override void Down()
        {
        }
    }
}
