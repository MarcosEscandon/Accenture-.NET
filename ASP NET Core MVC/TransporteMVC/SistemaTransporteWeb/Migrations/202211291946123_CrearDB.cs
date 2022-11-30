namespace SistemaTransporteWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autoes",
                c => new
                    {
                        AutoId = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Marca = c.String(nullable: false, maxLength: 50, unicode: false),
                        Ano = c.DateTime(nullable: false),
                        Color = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.AutoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Autoes");
        }
    }
}
