namespace KitapKurdu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2,20,1,20)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3,50,3,25)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4,180,12,30)");
        }

        public override void Down()
        {
        }
    }
}
