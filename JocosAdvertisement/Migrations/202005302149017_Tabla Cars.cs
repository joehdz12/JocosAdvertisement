namespace JocosAdvertisement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaCars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                        Model = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
