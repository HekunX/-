using Domain.BaseModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Model
{
    /// <summary>
    /// 学生选课表
    /// </summary>
    public class StudentSubjectList : IEntity
    {
        public Guid Identity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        [Key]
        public int ID { get; set; }
        [Required]
        public string SubjectListID { get; set; }
        [Required]
        public string StudentID { get; set; }

        /// <summary>
        /// 一条选课记录对应一个学生
        /// </summary>
        public virtual Student Student { set; get; }
        /// <summary>
        /// 一条选课记录对应一个课程信息
        /// </summary>
        public virtual SubjectList SubjectList { get; set; }

    }
}
