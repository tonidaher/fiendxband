namespace FiendXWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VenueContextCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 125),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Gigs", "Genre_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.Gigs", "Genre_Id");
            AddForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_Id" });
            AlterColumn("dbo.Gigs", "Venue", c => c.String());
            DropColumn("dbo.Gigs", "Genre_Id");
            DropTable("dbo.Genres");
        }
    }
}
