namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNameToMemberShipType1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String(maxLength: 100));
        }
    }
}
