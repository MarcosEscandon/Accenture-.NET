namespace PhotoSharingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        PhotoID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        PhotoFile = c.Binary(),
                        ImageMimeType = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.PhotoID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        PhotoID = c.Int(nullable: false),
                        UserName = c.String(),
                        Subject = c.String(nullable: false, maxLength: 250),
                        Body = c.String(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Photos", t => t.PhotoID, cascadeDelete: true)
                .Index(t => t.PhotoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "PhotoID", "dbo.Photos");
            DropIndex("dbo.Comments", new[] { "PhotoID" });
            DropTable("dbo.Comments");
            DropTable("dbo.Photos");
        }
    }
}
