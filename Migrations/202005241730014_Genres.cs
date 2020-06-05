namespace KitapKurdu.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Edebiyat')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Eðitim')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Bilim')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Kisisel Gelisim')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Mizah')");
        }

        public override void Down()
        {
        }
    }
}
