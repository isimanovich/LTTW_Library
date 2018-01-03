namespace LTTW_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectGenreBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Books", "GenreId");
            AddForeignKey("dbo.Books", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Books", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Genre", c => c.String(nullable: false, maxLength: 255));
            DropForeignKey("dbo.Books", "GenreId", "dbo.Genres");
            DropIndex("dbo.Books", new[] { "GenreId" });
            DropColumn("dbo.Books", "GenreId");
        }
    }
}
