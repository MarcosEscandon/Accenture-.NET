namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChauHora : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Turno", "HoraIngreso");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Turno", "HoraIngreso", c => c.Time(nullable: false, precision: 7));
        }
    }
}
