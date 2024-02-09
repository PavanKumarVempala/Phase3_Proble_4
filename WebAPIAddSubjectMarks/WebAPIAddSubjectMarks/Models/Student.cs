using System;
using System.Collections.Generic;

namespace WebAPIAddSubjectMarks.Models
{
    public partial class Student
    {
        public int StuId { get; set; }
        public string? StuName { get; set; }
        public int? StuClass { get; set; }
    }
}
