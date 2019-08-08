namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            DropForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists");
            DropForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers");
            AddForeignKey("dbo.Students", "ClassID", "dbo.Classes", "ClassID");
            AddForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists", "SubjectListID");
            AddForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms", "ClassroomID");
            AddForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses", "CourseID");
            AddForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers", "TeacherID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists");
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            AddForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers", "TeacherID", cascadeDelete: true);
            AddForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses", "CourseID", cascadeDelete: true);
            AddForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms", "ClassroomID", cascadeDelete: true);
            AddForeignKey("dbo.StudentSubjectLists", "SubjectListID", "dbo.SubjectLists", "SubjectListID", cascadeDelete: true);
            AddForeignKey("dbo.Students", "ClassID", "dbo.Classes", "ClassID", cascadeDelete: true);
        }
    }
}
