namespace CodeFirstVidzyOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VIDZYEFCODEFIRSTDB.\"Genres\" (\"Name\") VALUES ('Comedy')");
            Sql("INSERT INTO VIDZYEFCODEFIRSTDB.\"Genres\" (\"Name\") VALUES ('Action')");
            Sql("INSERT INTO VIDZYEFCODEFIRSTDB.\"Genres\" (\"Name\") VALUES ('Horror')");
            Sql("INSERT INTO VIDZYEFCODEFIRSTDB.\"Genres\" (\"Name\") VALUES ('Thriller')");
            Sql("INSERT INTO VIDZYEFCODEFIRSTDB.\"Genres\" (\"Name\") VALUES ('Family')");
            Sql("INSERT INTO VIDZYEFCODEFIRSTDB.\"Genres\" (\"Name\") VALUES ('Romance')");
        }

        public override void Down()
        {
        }
    }
}
