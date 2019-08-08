namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists");
            DropForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "ClassID" });
            DropIndex("dbo.StudentSubjectLists", new[] { "SubjectListID" });
            DropIndex("dbo.SubjectLists", new[] { "CourseID" });
            DropIndex("dbo.SubjectLists", new[] { "TeacherID" });
            DropIndex("dbo.SubjectLists", new[] { "ClassroomID" });
            AlterColumn("dbo.Students", "ClassID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentSubjectLists", "SubjectListID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.StudentSubjectLists", "StudentID", c => c.String(nullable: false));
            AlterColumn("dbo.SubjectLists", "CourseID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SubjectLists", "TeacherID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.SubjectLists", "ClassroomID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Students", "ClassID");
            CreateIndex("dbo.StudentSubjectLists", "SubjectListID");
            CreateIndex("dbo.SubjectLists", "CourseID");
            CreateIndex("dbo.SubjectLists", "TeacherID");
            CreateIndex("dbo.SubjectLists", "ClassroomID");
            AddForeignKey("dbo.Students", "ClassID", "dbo.Classes", "ClassID", cascadeDelete: true);
            AddForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists", "SubjectListID", cascadeDelete: true);
            AddForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms", "ClassroomID", cascadeDelete: true);
            AddForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
            AddForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers", "TeacherID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists");
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            DropIndex("dbo.SubjectLists", new[] { "ClassroomID" });
            DropIndex("dbo.SubjectLists", new[] { "TeacherID" });
            DropIndex("dbo.SubjectLists", new[] { "CourseID" });
            DropIndex("dbo.StudentSubjectLists", new[] { "SubjectListID" });
            DropIndex("dbo.Students", new[] { "ClassID" });
            AlterColumn("dbo.SubjectLists", "ClassroomID", c => c.String(maxLength: 128));
            AlterColumn("dbo.SubjectLists", "TeacherID", c => c.String(maxLength: 128));
            AlterColumn("dbo.SubjectLists", "CourseID", c => c.String(maxLength: 128));
            AlterColumn("dbo.StudentSubjectLists", "StudentID", c => c.String());
            AlterColumn("dbo.StudentSubjectLists", "SubjectListID", c => c.String(maxLength: 128));
            AlterColumn("dbo.Students", "ClassID", c => c.String(maxLength: 128));
            CreateIndex("dbo.SubjectLists", "ClassroomID");
            CreateIndex("dbo.SubjectLists", "TeacherID");
            CreateIndex("dbo.SubjectLists", "CourseID");
            CreateIndex("dbo.StudentSubjectLists", "SubjectListID");
            CreateIndex("dbo.Students", "ClassID");
            AddForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers", "TeacherID");
            AddForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses", "CourseID");
            AddForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms", "ClassroomID");
            AddForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists", "SubjectListID");
            AddForeignKey("dbo.Students", "ClassID", "dbo.Classes", "ClassID");
        }
    }
}
