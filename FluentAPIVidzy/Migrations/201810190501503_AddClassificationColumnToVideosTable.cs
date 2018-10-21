namespace FluentAPIVidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClassificationColumnToVideosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "ClassificationType", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Videos", "ClassificationType");
        }
    }
}
