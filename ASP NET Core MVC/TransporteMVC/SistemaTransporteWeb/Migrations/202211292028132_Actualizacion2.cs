namespace SistemaTransporteWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Actualizacion2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Auto", "Anio", c => c.Int(nullable: false));
            DropColumn("dbo.Auto", "Ano");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Auto", "Ano", c => c.DateTime(nullable: false));
            DropColumn("dbo.Auto", "Anio");
        }
    }
}
