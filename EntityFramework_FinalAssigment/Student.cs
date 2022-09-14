using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_FinalAssigment
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //? nullable
        public byte Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public virtual Grade Grade { get; set; }

    }
}
