namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInVideosAndGenresTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn("VIDZYEFCODEFIRSTDB.Videos", "Name", "Name_old");
            AddColumn("VIDZYEFCODEFIRSTDB.Videos", "Name", c => c.String(maxLength: 3999, unicode: false));
            Sql("UPDATE VIDZYEFCODEFIRSTDB.\"Videos\" SET \"Name\" = \"Name_old\"");
            DropColumn("VIDZYEFCODEFIRSTDB.Videos", "Name_old");
            AlterColumn("VIDZYEFCODEFIRSTDB.Videos", "Name", c => c.String(nullable: false, maxLength: 255, unicode: false));

            RenameColumn("VIDZYEFCODEFIRSTDB.Genres", "Name", "Name_old");
            AddColumn("VIDZYEFCODEFIRSTDB.Genres", "Name", c => c.String(maxLength: 3999, unicode: false));
            Sql("UPDATE VIDZYEFCODEFIRSTDB.\"Genres\" SET \"Name\" = \"Name_old\"");
            DropColumn("VIDZYEFCODEFIRSTDB.Genres", "Name_old");
            AlterColumn("VIDZYEFCODEFIRSTDB.Genres", "Name", c => c.String(nullable: false, maxLength: 255, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("VIDZYEFCODEFIRSTDB.Genres", "Name", c => c.String(maxLength: 3999, unicode: false));
            AlterColumn("VIDZYEFCODEFIRSTDB.Videos", "Name", c => c.String(maxLength: 3999, unicode: false));
        }
    }
}
