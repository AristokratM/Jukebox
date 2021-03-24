namespace Jukebox.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlbumEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        ItemPlayPrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SongEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        Author = c.String(),
                        Performer = c.String(),
                        Duration = c.Single(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ContainerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SongEntities");
            DropTable("dbo.AlbumEntities");
        }
    }
}
