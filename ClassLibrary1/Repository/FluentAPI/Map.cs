using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Infrastructure.Repository.FluentAPI
{
    public class ClassMap: EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            
        }
    }
    public class ClassroomMap:EntityTypeConfiguration<Classroom>
    {
        public ClassroomMap()
        {

        }
    }

    public class CourseMap:EntityTypeConfiguration<Course>
    {
        public CourseMap()
        {

        }
    }
    public class StudentMap:EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
                
        }
    }
    public class SubjectListMap:EntityTypeConfiguration<SubjectList>
    {
        public SubjectListMap()
        {
          //  this.HasRequired(t => t.Student).WithMany(t => t.SubjectListes).HasForeignKey(t => t.student)
        }

        public class TeacherMap:EntityTypeConfiguration<Teacher>
        {
            public TeacherMap()
            {
                HasKey(t => t.TeacherID);
            }
        }


    }
}
