namespace IT_Aplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Carts", "Name", c => c.String());
            AlterColumn("dbo.Carts", "Recommended_dose", c => c.String());
            AlterColumn("dbo.Carts", "Expiration_date", c => c.String());
            AlterColumn("dbo.Carts", "Company", c => c.String());
            AlterColumn("dbo.Carts", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Carts", "ImageURL", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Company", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Expiration_date", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Recommended_dose", c => c.String(nullable: false));
            AlterColumn("dbo.Carts", "Name", c => c.String(nullable: false));
        }
    }
}
