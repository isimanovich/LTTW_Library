namespace LTTW_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookAndAnnotations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Stock", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Books", "Genre", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Books", "Isbn", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Books", "Publisher", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Publisher", c => c.String());
            AlterColumn("dbo.Books", "Isbn", c => c.String());
            AlterColumn("dbo.Books", "Genre", c => c.String());
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "Title", c => c.String());
            DropColumn("dbo.Books", "Stock");
        }
    }
}
