namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesVideosAndGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GenreVideos",
                c => new
                    {
                        Genre_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Video_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Video_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Videos", t => t.Video_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Video_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GenreVideos", "Video_Id", "dbo.Videos");
            DropForeignKey("dbo.GenreVideos", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.GenreVideos", new[] { "Video_Id" });
            DropIndex("dbo.GenreVideos", new[] { "Genre_Id" });
            DropTable("dbo.GenreVideos");
            DropTable("dbo.Genres");
            DropTable("dbo.Videos");
        }
    }
}
