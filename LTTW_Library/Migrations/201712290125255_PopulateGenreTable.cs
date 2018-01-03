namespace LTTW_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            /*
             * •Science fiction
                •Drama
                •Action and Adventure
                •Romance
                •Mystery
                •Health
                •Guide
                •Travel
                •Children's
                •Religion
                •Science
                •History
                •Poetry
                •Encyclopedias
                •Dictionaries
                •Art
                •Journals
                •Prayer books
                •Series
                •Trilogy 
                •Biographies
                •Autobiographies
                •Fantasy
                •Fiction
                •Non-fiction
             */
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Science Fiction')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Drama')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Action and Adventure')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Romance')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(5, 'Mystery')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(6, 'Health')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(7, 'Guide')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(8, 'Travel')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(9, 'Children')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(10, 'Religion')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(11, 'Science')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(12, 'History')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(13, 'Poetry')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(14, 'Encyclopedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(15, 'Dictionary')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(16, 'Art')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(17, 'Journal')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(18, 'Prayer book')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(19, 'Series')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(20, 'Trilogy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(21, 'Biography')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(22, 'Autobiography')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(23, 'Fantasy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(24, 'Fiction')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(25, 'Non-fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
