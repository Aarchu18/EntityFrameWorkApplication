using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkConsoleApplication
{
    public class Course
    {
        
        public int CourseId { set; get; }
        public string CourseName { set; get; }
        public int CourseFee { set; get; }
        public string CourseSession { set; get; }
        public List<Student> Students { set; get; }

        [ForeignKey("CourseId")]

        public Course Courses { set; get; }
    }
}
