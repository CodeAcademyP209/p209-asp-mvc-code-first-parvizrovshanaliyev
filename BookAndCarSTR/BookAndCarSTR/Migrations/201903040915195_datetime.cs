namespace BookAndCarSTR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Update", c => c.DateTime());
            AlterColumn("dbo.Cars", "Update", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Update", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Books", "Update", c => c.DateTime(nullable: false));
        }
    }
}
