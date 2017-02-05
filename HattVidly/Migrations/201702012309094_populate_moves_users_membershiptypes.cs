using System.Web.UI.WebControls;

namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_moves_users_membershiptypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Movies(Name) values('Guardians of the Galaxy')");
            Sql("insert into Movies(Name) values('Wall-e')");
            Sql("insert into Movies(Name) values('Godzilla')");
            //Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, BirthDate) values('Samantha', '1', '1', '01/01/1998')");
            //Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, BirthDate) values('Beth', '0', '2', '10/12/1995')");
            //Sql("insert into Customers(Name, IsSubscribedToNewsletter, MembershipTypeId, BirthDate) values('Yvonne', '0', '3', '7/4/2000')");
        }
        
        public override void Down()
        {
        }
    }
}
