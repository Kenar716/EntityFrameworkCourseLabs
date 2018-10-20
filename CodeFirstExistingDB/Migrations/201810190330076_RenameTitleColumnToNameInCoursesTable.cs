namespace CodeFirstExistingDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTitleColumnToNameInCoursesTable : DbMigration
    {
        public override void Up()
        {
            //This way we will lost al data in column Title
            //AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            //DropColumn("dbo.Courses", "Title");

            //Option 1
            //RenameColumn("dbo.Courses", "Title", "Name");

            //Option 2
            AddColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            Sql("UPDATE Courses SET Name = Title");
            DropColumn("dbo.Courses", "Title");
        }
        
        public override void Down()
        {
            //Always check Down methos so we can reverse the database 
            //to a previus state on a secure way

            //AddColumn("dbo.Courses", "Title", c => c.String());
            //DropColumn("dbo.Courses", "Name");

            AddColumn("dbo.Courses", "Title", c => c.String());
            Sql("UPDATE Courses SET Tile = Name");
            DropColumn("dbo.Courses", "Name");
            
        }
    }
}
