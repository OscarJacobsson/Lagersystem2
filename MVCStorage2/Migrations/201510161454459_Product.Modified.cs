namespace MVCStorage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModified : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Modified", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Modified");
        }
    }
}
