namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationTypeColumnOnVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("VIDZYEFCODEFIRSTDB.Videos", "ClassificationType", c => c.Decimal(nullable: false, precision: 3, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("VIDZYEFCODEFIRSTDB.Videos", "ClassificationType");
        }
    }
}
