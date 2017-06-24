namespace FiendXWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GigContextCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gigs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Venue = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gigs");
        }
    }
}
