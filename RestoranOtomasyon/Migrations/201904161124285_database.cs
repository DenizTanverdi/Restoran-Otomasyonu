namespace RestoranOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(nullable: false, maxLength: 50),
                        MailAddress = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 250),
                        Address = c.String(nullable: false, maxLength: 250),
                        Gender = c.Boolean(),
                        IsActive = c.Boolean(nullable: false),
                        SaveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(nullable: false, maxLength: 50),
                        MailAddress = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 250),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        Gender = c.Boolean(),
                        IsActive = c.Boolean(nullable: false),
                        SaveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 250),
                        Phone = c.String(nullable: false, maxLength: 50),
                        MailAddress = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 250),
                        UserName = c.String(maxLength: 250),
                        ProductName = c.String(maxLength: 250),
                        Adress = c.String(maxLength: 250),
                        OrderType = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        ProductId = c.Int(nullable: false),
                        State = c.Boolean(nullable: false),
                        Piece = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 250),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        CategoryId = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Table",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        State = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Table");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
            DropTable("dbo.Manager");
            DropTable("dbo.Employee");
            DropTable("dbo.Customer");
        }
    }
}
