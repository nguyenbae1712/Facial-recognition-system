namespace QuanlySieuthi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CatId = c.Int(nullable: false, identity: true),
                        CatName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CatId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProdID = c.Int(nullable: false),
                        STT = c.Int(nullable: false, identity: true),
                        ProdName = c.String(nullable: false, maxLength: 150),
                        DateIn = c.DateTime(nullable: false),
                        NSX = c.String(maxLength: 150),
                        State = c.Boolean(nullable: false),
                        CatId = c.Int(),
                    })
                .PrimaryKey(t => t.ProdID)
                .ForeignKey("dbo.Category", t => t.CatId)
                .Index(t => t.CatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "CatId", "dbo.Category");
            DropIndex("dbo.Product", new[] { "CatId" });
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
