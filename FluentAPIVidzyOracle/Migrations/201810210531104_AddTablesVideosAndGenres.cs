namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTablesVideosAndGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "VIDZYEFCODEFIRSTDB.Videos",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VIDZYEFCODEFIRSTDB.Genres",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VIDZYEFCODEFIRSTDB.GenreVideos",
                c => new
                    {
                        Genre_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Video_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Video_Id })
                .ForeignKey("VIDZYEFCODEFIRSTDB.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("VIDZYEFCODEFIRSTDB.Videos", t => t.Video_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Video_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("VIDZYEFCODEFIRSTDB.GenreVideos", "Video_Id", "VIDZYEFCODEFIRSTDB.Videos");
            DropForeignKey("VIDZYEFCODEFIRSTDB.GenreVideos", "Genre_Id", "VIDZYEFCODEFIRSTDB.Genres");
            DropIndex("VIDZYEFCODEFIRSTDB.GenreVideos", new[] { "Video_Id" });
            DropIndex("VIDZYEFCODEFIRSTDB.GenreVideos", new[] { "Genre_Id" });
            DropTable("VIDZYEFCODEFIRSTDB.GenreVideos");
            DropTable("VIDZYEFCODEFIRSTDB.Genres");
            DropTable("VIDZYEFCODEFIRSTDB.Videos");
        }
    }
}
