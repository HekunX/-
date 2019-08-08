using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq.Expressions;
using Domain.Model;

namespace Infrastructure.Repository
{
    public class EFContext:DbContext
    {
        public DbSet<Class> Classe { get; set; }
        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentSubjectList> StudentSubjectList { get; set; }
        public DbSet<SubjectList> SubjectList { get; set; }
        public DbSet<Teacher> Teacher { get; set; }





        public EFContext():base("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=HK;Data Source=WIN10")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<EFContext>(null);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            //关闭级联删除
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
