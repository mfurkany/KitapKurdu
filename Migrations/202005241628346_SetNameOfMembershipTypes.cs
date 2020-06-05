namespace KitapKurdu.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Ma�azada �de' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Ayl�k �yelik' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = '3 Ayl�k �yelik' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Y�ll�k �yelik' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
