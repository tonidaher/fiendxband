namespace FiendXWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenerateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres(Id,Name) VALUES(1,'Rock')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(2,'Metal')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(3,'Hard Rock')");
            Sql("INSERT INTO Genres(Id,Name) VALUES(4,'Alternative')");
            Sql("SET IDENTITY_INSERT Genres OFF");
        }
        
        public override void Down()
        {
            Sql("TRUNCATE TABLE Genres");
        }
    }
}
