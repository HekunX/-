namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassID = c.String(nullable: false, maxLength: 128),
                        Identity = c.Guid(nullable: false),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.ClassID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Identity = c.Guid(nullable: false),
                        StudnetName = c.String(),
                        HomeAddress = c.String(),
                        PhoneNumber = c.String(),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        ClassID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Classes", t => t.ClassID)
                .Index(t => t.ClassID);
            
            CreateTable(
                "dbo.StudentSubjectLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Identity = c.Guid(nullable: false),
                        SubjectListID = c.String(),
                        StudentID = c.String(),
                        Student_StudentID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.Student_StudentID)
                .Index(t => t.Student_StudentID);
            
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomID = c.String(nullable: false, maxLength: 128),
                        Identity = c.Guid(nullable: false),
                        ClassroomName = c.String(),
                        SeatCount = c.Int(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ClassroomID);
            
            CreateTable(
                "dbo.SubjectLists",
                c => new
                    {
                        SubjectListID = c.String(nullable: false, maxLength: 128),
                        Identity = c.Guid(nullable: false),
                        CourseID = c.String(maxLength: 128),
                        TeacherID = c.String(maxLength: 128),
                        ClassroomID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SubjectListID)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomID)
                .ForeignKey("dbo.Courses", t => t.CourseID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID)
                .Index(t => t.CourseID)
                .Index(t => t.TeacherID)
                .Index(t => t.ClassroomID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseID = c.String(nullable: false, maxLength: 128),
                        Identity = c.Guid(nullable: false),
                        CourseName = c.String(),
                        CourseTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.String(nullable: false, maxLength: 128),
                        Identity = c.Guid(nullable: false),
                        TeacherName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubjectLists", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.SubjectLists", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.SubjectLists", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.StudentSubjectLists", "Student_StudentID", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassID", "dbo.Classes");
            DropIndex("dbo.SubjectLists", new[] { "ClassroomID" });
            DropIndex("dbo.SubjectLists", new[] { "TeacherID" });
            DropIndex("dbo.SubjectLists", new[] { "CourseID" });
            DropIndex("dbo.StudentSubjectLists", new[] { "Student_StudentID" });
            DropIndex("dbo.Students", new[] { "ClassID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.SubjectLists");
            DropTable("dbo.Classrooms");
            DropTable("dbo.StudentSubjectLists");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
