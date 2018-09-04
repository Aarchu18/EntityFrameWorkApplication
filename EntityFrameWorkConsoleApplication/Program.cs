using System;

namespace EntityFrameWorkConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();

            Console.WriteLine("Enter Your Choice:\n" +
                " 1.View All  Student Data\n" +
                " 2.Add New Course\n " +
                "3.Add New Student\n " +
                "4.Update Student\n" +
                "5.Delete Student\n" +
                "6.Exit"
                );
            var userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    program.ViewStudentData();
                    break;
                case 2:
                    program.CourseAdd();
                    break;
                case 3:
                    program.StudentAdd();
                    break;
                case 4:
                    program.StudentUpdate();
                    break;
                case 5:
                    program.StudentDelete();
                    break;
                default:
                    Console.WriteLine("Enter Correct Choice!!");
                    break;
            }
            Console.ReadKey();


        }
        private void StudentAdd()
        {
            using (StudentModel studentModel = new StudentModel())
            {
                Console.Write("Enter Your First Name:");
                String StudentFirstName = Console.ReadLine();
                Console.Write("Enter Your Last Name:");
                String StudentLastName = Console.ReadLine();
                Console.Write("Enter Your Gender:");
                String StudentGender = Console.ReadLine();
                Console.Write("Enter Your Choice:");

                foreach( var data in studentModel.Courses)
                {
                    Console.WriteLine(data.CourseName + " For " + data.CourseId);


                }
                int CourseId = Convert.ToInt32(Console.ReadLine());

                Student student = new Student()
                {
                    StudentFirstName = StudentFirstName,
                    StudentLastName = StudentLastName,
                    StudentGender = StudentGender

                };

                studentModel.Students.Add(student);
                studentModel.SaveChanges();
            }
        }
        private  void CourseAdd()
        {
            using (StudentModel studentModel = new StudentModel())
            {
                Console.WriteLine("Enter Your Course Name:");
                String CourseName = Console.ReadLine();
                Console.WriteLine("Enter Your Course Fee:");
                int CourseFee = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Course Session:");
                String Coursesession = Console.ReadLine();

                 Course course = new Course()
                 {
                    CourseName = CourseName,
                    CourseFee = CourseFee,
                    CourseSession = Coursesession
                    

                 };

                studentModel.Courses.Add(course);
                studentModel.SaveChanges();
            }

        }


        private  void StudentUpdate()
        {

        }
        private void StudentDelete()
        {

        }
        private  void ViewStudentData()
        {

        }

    }
}

