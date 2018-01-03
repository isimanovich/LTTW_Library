namespace LTTW_Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "First", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Last", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "Phone", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Phone", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Last", c => c.String());
            AlterColumn("dbo.Customers", "First", c => c.String());
        }
    }
}
