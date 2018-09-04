using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkConsoleApplication
{
    public class Student
    {
        [Key]
        public int StudentId { set; get; }
        public int CourseId { set; get; }
        public String StudentFirstName{ set; get; }
        public String StudentLastName { set; get; }
        public String StudentGender { set; get; }

     
    }
}
