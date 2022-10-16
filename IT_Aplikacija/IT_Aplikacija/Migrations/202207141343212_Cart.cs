namespace IT_Aplikacija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Weight = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Recommended_dose = c.String(nullable: false),
                        Expiration_date = c.String(nullable: false),
                        Company = c.String(nullable: false),
                        ImageURL = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CartID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carts");
        }
    }
}
