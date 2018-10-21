namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRelationshipOneToOneAtVideoGenresTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("VIDZYEFCODEFIRSTDB.GenreVideos", "Genre_Id", "VIDZYEFCODEFIRSTDB.Genres");
            DropForeignKey("VIDZYEFCODEFIRSTDB.GenreVideos", "Video_Id", "VIDZYEFCODEFIRSTDB.Videos");
            DropIndex("VIDZYEFCODEFIRSTDB.GenreVideos", new[] { "Genre_Id" });
            DropIndex("VIDZYEFCODEFIRSTDB.GenreVideos", new[] { "Video_Id" });
            AddColumn("VIDZYEFCODEFIRSTDB.Videos", "GenreId", c => c.Decimal(nullable: false, precision: 10, scale: 0));
            CreateIndex("VIDZYEFCODEFIRSTDB.Videos", "GenreId");
            AddForeignKey("VIDZYEFCODEFIRSTDB.Videos", "GenreId", "VIDZYEFCODEFIRSTDB.Genres", "Id", cascadeDelete: true);
            DropTable("VIDZYEFCODEFIRSTDB.GenreVideos");
        }
        
        public override void Down()
        {
            CreateTable(
                "VIDZYEFCODEFIRSTDB.GenreVideos",
                c => new
                    {
                        Genre_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Video_Id = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Video_Id });
            
            DropForeignKey("VIDZYEFCODEFIRSTDB.Videos", "GenreId", "VIDZYEFCODEFIRSTDB.Genres");
            DropIndex("VIDZYEFCODEFIRSTDB.Videos", new[] { "GenreId" });
            DropColumn("VIDZYEFCODEFIRSTDB.Videos", "GenreId");
            CreateIndex("VIDZYEFCODEFIRSTDB.GenreVideos", "Video_Id");
            CreateIndex("VIDZYEFCODEFIRSTDB.GenreVideos", "Genre_Id");
            AddForeignKey("VIDZYEFCODEFIRSTDB.GenreVideos", "Video_Id", "VIDZYEFCODEFIRSTDB.Videos", "Id", cascadeDelete: true);
            AddForeignKey("VIDZYEFCODEFIRSTDB.GenreVideos", "Genre_Id", "VIDZYEFCODEFIRSTDB.Genres", "Id", cascadeDelete: true);
        }
    }
}
