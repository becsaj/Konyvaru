namespace Konyvaru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Konyvek : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Konyvs (Szerzo, Cim, Keszlet, Kep, Ar, KategoriaId) VALUES " +
    $"('Andrzej Sapkowski', 'Witcher','{new Random().Next(10, 20)}','witcher.jpg','4000', 1)," +
    $"('George R. R. Martin', 'Trónok harca','{new Random().Next(10, 20)}','tronok.jpg','3500', 1)," +
    $"('Michael Crichton', 'Az elveszett világ','{new Random().Next(10, 20)}','vilag.jpg','2500', 2)," +
    $"('Stephen King', 'Az','{new Random().Next(10, 20)}','az.jpg','4000', 3)," +
    $"('Jack London', 'Adventure','{new Random().Next(10, 20)}','adv.jpg','1500', 2)");

  
        }

        public override void Down()
        {
        }
    }
}
