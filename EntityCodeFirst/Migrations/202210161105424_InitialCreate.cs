namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.urunlers",
                c => new
                    {
                        urunıd = c.Int(nullable: false, identity: true),
                        urunad = c.String(),
                        urunmarka = c.String(),
                        urunkategori = c.String(),
                        urunstok = c.Int(nullable: false),
                        aciklama = c.String(),
                    })
                .PrimaryKey(t => t.urunıd);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.urunlers");
        }
    }
}
