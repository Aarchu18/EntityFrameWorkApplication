namespace EntityFrameWorkConsoleApplication
{
    using System.Data.Entity;

    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel")
        {
        }

        public   DbSet<Course> Courses { set; get; }
        public DbSet<Student> Students { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
