namespace KitapKurdu.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SetNameOfMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Maðazada Öde' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Aylýk Üyelik' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = '3 Aylýk Üyelik' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Yýllýk Üyelik' WHERE Id = 4");
        }

        public override void Down()
        {
        }
    }
}
