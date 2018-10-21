namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTagsTableAndRelationshipManyToManyWithVideosTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "VIDZYEFCODEFIRSTDB.Tags",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VIDZYEFCODEFIRSTDB.VideoTags",
                c => new
                    {
                        VideoId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        TagId = c.Decimal(nullable: false, precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.VideoId, t.TagId })
                .ForeignKey("VIDZYEFCODEFIRSTDB.Videos", t => t.VideoId, cascadeDelete: true)
                .ForeignKey("VIDZYEFCODEFIRSTDB.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.VideoId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("VIDZYEFCODEFIRSTDB.VideoTags", "TagId", "VIDZYEFCODEFIRSTDB.Tags");
            DropForeignKey("VIDZYEFCODEFIRSTDB.VideoTags", "VideoId", "VIDZYEFCODEFIRSTDB.Videos");
            DropIndex("VIDZYEFCODEFIRSTDB.VideoTags", new[] { "TagId" });
            DropIndex("VIDZYEFCODEFIRSTDB.VideoTags", new[] { "VideoId" });
            DropTable("VIDZYEFCODEFIRSTDB.VideoTags");
            DropTable("VIDZYEFCODEFIRSTDB.Tags");
        }
    }
}
