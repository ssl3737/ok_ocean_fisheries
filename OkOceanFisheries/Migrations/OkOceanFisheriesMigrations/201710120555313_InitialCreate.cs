namespace OkOceanFisheries.Migrations.OkOceanFisheriesMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        BuyerId = c.Int(nullable: false, identity: true),
                        DateTimeCreated = c.DateTime(nullable: false),
                        OwnerFirstName = c.String(),
                        OwnerLastName = c.String(),
                        CompanyName = c.String(),
                        Contact = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.BuyerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        OriginCountry = c.String(),
                        CatchTime = c.String(),
                        Quantity = c.String(),
                        Price = c.String(),
                        BuyerId = c.Int(),
                        ProductOptionId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Buyers", t => t.BuyerId)
                .ForeignKey("dbo.ProductOptions", t => t.ProductOptionId)
                .Index(t => t.BuyerId)
                .Index(t => t.ProductOptionId);
            
            CreateTable(
                "dbo.ProductOptions",
                c => new
                    {
                        ProductOptionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductOptionId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Contact = c.String(),
                        Position = c.String(),
                        Email = c.String(),
                        HourlyWage = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ProductOptionId", "dbo.ProductOptions");
            DropForeignKey("dbo.Products", "BuyerId", "dbo.Buyers");
            DropIndex("dbo.Products", new[] { "ProductOptionId" });
            DropIndex("dbo.Products", new[] { "BuyerId" });
            DropTable("dbo.Employees");
            DropTable("dbo.ProductOptions");
            DropTable("dbo.Products");
            DropTable("dbo.Buyers");
        }
    }
}
