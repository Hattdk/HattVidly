namespace HattVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class wtf_errors : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes");
            //DropIndex("dbo.Customers", new[] { "MembershipType_Id" });
            //DropColumn("dbo.Customers", "MembershipTypeId");
            //RenameColumn(table: "dbo.Customers", name: "MembershipType_Id", newName: "MembershipTypeId");
            ////DropPrimaryKey("dbo.MembershipTypes");
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            AddColumn("dbo.MembershipTypes", "DurationInMonths", c => c.Byte(nullable: false));
            AddColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
            ////AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            ////AlterColumn("dbo.MembershipTypes", "Id", c => c.Byte(nullable: false));
            //AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));
            //AddPrimaryKey("dbo.MembershipTypes", "Id");
            //CreateIndex("dbo.Customers", "MembershipTypeId");
            //AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            //DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            //DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            //DropPrimaryKey("dbo.MembershipTypes");
            //AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
            ////AlterColumn("dbo.MembershipTypes", "Id", c => c.Int(nullable: false, identity: true));
            ////AlterColumn("dbo.Customers", "MembershipTypeId", c => c.Int());
            //DropColumn("dbo.MembershipTypes", "DiscountRate");
            //DropColumn("dbo.MembershipTypes", "DurationInMonths");
            //DropColumn("dbo.MembershipTypes", "SignUpFee");
            //AddPrimaryKey("dbo.MembershipTypes", "Id");
            //RenameColumn(table: "dbo.Customers", name: "MembershipTypeId", newName: "MembershipType_Id");
            //AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            //CreateIndex("dbo.Customers", "MembershipType_Id");
            //AddForeignKey("dbo.Customers", "MembershipType_Id", "dbo.MembershipTypes", "Id");
        }
    }
}
