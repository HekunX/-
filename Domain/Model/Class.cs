using Domain.BaseModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Model
{
    /// <summary>
    /// 班级表
    /// </summary>
    public class Class : IEntity
    {
        public Guid Identity { get; set; }

        /// <summary>
        /// 班级编号
        /// </summary>
        [Key]
        public string  ClassID { get; set; }
        /// <summary>
        /// 班级名
        /// </summary>
        public string ClassName { get; set; }

        //一个班级有许多学生
        public virtual List<Student> Students { get;set; }
    }
}
