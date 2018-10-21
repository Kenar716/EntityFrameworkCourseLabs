namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInVideosAndGenresTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("VIDZYEFCODEFIRSTDB.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("VIDZYEFCODEFIRSTDB.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("VIDZYEFCODEFIRSTDB.Genres", "Name", c => c.String());
            AlterColumn("VIDZYEFCODEFIRSTDB.Videos", "Name", c => c.String());
        }
    }
}
