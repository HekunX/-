﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Domain;
using Domain.BaseModule;

namespace Domain.Model
{
    /// <summary>
    /// 教师信息表
    /// </summary>
    public class Teacher :IEntity
    {
        public  Guid Identity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// 教师ID
        /// </summary>
        [Key]
        public string TeacherID { get; set; }
        /// <summary>
        /// 教师姓名
        /// </summary>
        public string TeacherName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public UInt16 Age  { get; set; }
        /// <summary>
        /// 住址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 一个老师可以教多门课
        /// </summary>
        public virtual List<SubjectList> SubjectLists { get; set; }
      
    }
}
