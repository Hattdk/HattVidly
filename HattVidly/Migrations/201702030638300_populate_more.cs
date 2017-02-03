namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populate_more : DbMigration
    {
        public override void Up()
        {
            //Sql("SET IDENTITY_INSERT Genres ON;");
            //Sql("SET IDENTITY_INSERT Movies ON;");
            //Sql("SET IDENTITY_INSERT Customers ON;");
            
            Sql("insert into Genres(Id, Name) values(1, 'Animated')");
            Sql("insert into Genres(Id, Name) values(2, 'Action')");
            Sql("insert into Genres(Id, Name) values(3, 'Foreign')");

            //Sql("insert into Movies(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values(1, 'Wall-e', 1, '1/1/2005', '1/1/2004', 5)");
            //Sql("insert into Movies(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values(2, 'Guardians of the Galaxy', 1, '1/1/2010', '1/1/2010', 50)");
            //Sql("insert into Movies(Id, Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values(3, 'Amelie', 1, '1/1/1999', '1/1/1999', 2)");

            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Wall-e', 1, '1/1/2005', '1/1/2004', 5)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Guardians of the Galaxy', 1, '1/1/2010', '1/1/2010', 50)");
            Sql("insert into Movies(Name, GenreId, DateAdded, ReleaseDate, NumberInStock) values('Amelie', 1, '1/1/1999', '1/1/1999', 2)");

            Sql("insert into Customers(Name, IsSubscribedToNewsletter, Birthdate, MembershipTypeId) values('Beth', 1, '1/1/2001', 17)");
            Sql("insert into Customers(Name, IsSubscribedToNewsletter, Birthdate, MembershipTypeId) values('Sarah', 0, '2/2/2002', 18)");
            Sql("insert into Customers(Name, IsSubscribedToNewsletter, Birthdate, MembershipTypeId) values('Jackie', 1, '3/3/2003', 19)");
            Sql("insert into Customers(Name, IsSubscribedToNewsletter, Birthdate, MembershipTypeId) values('Frank', 1, '3/3/2003', 20)");

            //Sql("SET IDENTITY_INSERT Genres OFF;");
            Sql("SET IDENTITY_INSERT Movies OFF;");
            Sql("SET IDENTITY_INSERT Customers OFF;");
            Sql("SET IDENTITY_INSERT MembershipTypes OFF;");
        }

        public override void Down()
        {
        }
    }
}
