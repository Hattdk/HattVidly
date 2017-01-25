namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToIdentityModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsSubscribedToNewsletter = c.Boolean(nullable: false),
                        MembershipTypeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignupFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("insert into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate values (1, 0, 0, 0)");
            Sql("insert into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate values (2, 30, 1, 10)");
            Sql("insert into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate values (3, 90, 3, 15)");
            Sql("insert into MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRate values (4, 300, 12, 20)");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Customers");
        }
    }
}
