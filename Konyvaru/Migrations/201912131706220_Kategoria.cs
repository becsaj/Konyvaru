namespace Konyvaru.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kategoria : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Kategorias(Megnevezes, Nepszeruseg) VALUES " +
                "('Fantasy', 8 )," +
                "('Adventure' , 7 )," +
                "('Horror', 6)");
        }
        
        public override void Down()
        {
        }
    }
}
