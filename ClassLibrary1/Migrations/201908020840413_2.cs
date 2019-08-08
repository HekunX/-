namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentSubjectLists", "SubjectListID", c => c.String(maxLength: 128));
            CreateIndex("dbo.StudentSubjectLists", "SubjectListID");
            AddForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists", "SubjectListID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists");
            DropIndex("dbo.StudentSubjectLists", new[] { "SubjectListID" });
            AlterColumn("dbo.StudentSubjectLists", "SubjectListID", c => c.String());
        }
    }
}
