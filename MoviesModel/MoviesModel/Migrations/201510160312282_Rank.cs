namespace MoviesModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rank : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rank", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rank");
        }
    }
}
