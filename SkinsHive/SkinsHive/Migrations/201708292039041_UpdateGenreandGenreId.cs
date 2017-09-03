namespace SkinsHive.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGenreandGenreId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Movies", "GenreId");
        }
    }
}
