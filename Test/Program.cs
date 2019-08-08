using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Test
{
    public class Teacher
    {
        public int ID { get; set; }
        public string TeacherName { get; set; }

        public virtual List<Course> Courses { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }

        public int TeacherID{ get; set; }
        public int StudentID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }


    }
    public class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }

        public virtual List<Course> Courses { get; set; }
    }

    public class MyDbContext:DbContext
    {

        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Courses { get; set; }

        public MyDbContext():base("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Test;Data Source=WIN10")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<MyDbContext>(null);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext db = new MyDbContext();
            db.Teacher.Add(new Teacher() { ID = 1, TeacherName = "肖峰" } );
            db.SaveChanges();
            

        }
    }
}
