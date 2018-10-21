namespace FluentAPIVidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres(Id, Name) VALUES(1, 'Comedy')");
            Sql("INSERT INTO dbo.Genres(Id, Name) VALUES(2, 'Musical')");
            Sql("INSERT INTO dbo.Genres(Id, Name) VALUES(3, 'Anime')");
        }
        
        public override void Down()
        {
        }
    }
}
