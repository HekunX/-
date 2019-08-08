namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Students", new[] { "ClassID" });
            AlterColumn("dbo.Students", "ClassID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Students", "ClassID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Students", new[] { "ClassID" });
            AlterColumn("dbo.Students", "ClassID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Students", "ClassID");
        }
    }
}
