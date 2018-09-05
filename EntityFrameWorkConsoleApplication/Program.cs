using System;
using System.Linq;

namespace EntityFrameWorkConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Program program = new Program();
            string userChoice = " ";
            
            while (userChoice != "6")
            {
                DisplayData();
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                   
                    case "1":
                        program.ViewStudentData();
                        Console.WriteLine("---------------------");
                        break;
                    case "2":
                        program.CourseAdd();
                        Console.WriteLine("---------------------");
                        break;
                    case "3":
                        program.StudentAdd();
                        Console.WriteLine("---------------------");
                        break;
                    case "4":
                        program.StudentUpdate();
                        Console.WriteLine("---------------------");
                        break;
                    case "5":
                        program.StudentDelete();
                        Console.WriteLine("---------------------");
                        break;
                    case "6":
                        break;

                    default:
                        Console.WriteLine("You Have Entered Wrong Choice!!");
                        break;
                }
            }

        }
       
        private static void DisplayData()
        {
            Console.WriteLine("Enter Your Choice:\n"+
            " 1.View All  Student Data\n"+
            " 2.Add New Course\n"+
            " 3.Add New Student\n"+
            " 4.Update Student\n"+
            " 5.Delete Student\n"+
            " 6.Exit"
            );
            Console.WriteLine("---------------------");

        }
        
        private void StudentAdd()
        {
            using (StudentModel studentModel = new StudentModel())
            {

                Console.WriteLine("Enter Your First Name:");
                String StudentFirstName = Console.ReadLine();
                Console.WriteLine("Enter Your Last Name:");
                String StudentLastName = Console.ReadLine();
                Console.WriteLine("Enter Your Gender:\n" + "1.Male\n" + "2.Female");
                int Gender = Convert.ToInt32(Console.ReadLine());
                string studentGender = " ";
                if (Gender == 1)
                {
                    studentGender = "Male";
                }
                if (Gender == 2)
                {
                    studentGender = "Female";
                }
                Console.WriteLine("Enter Your Choice:");

                foreach (var data in studentModel.Courses)
                {
                    Console.WriteLine(data.CourseId + " : " + data.CourseName);
                }

                int CourseId = Convert.ToInt32(Console.ReadLine());

                Student student = new Student()
                {
                    StudentFirstName = StudentFirstName,
                    StudentLastName = StudentLastName,
                    StudentGender = studentGender,
                    CourseId = CourseId

                };

                studentModel.Students.Add(student);
                studentModel.SaveChanges();
            }
        }
        
        private void CourseAdd()
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
        
        private void StudentUpdate()
        {
            using (StudentModel studentModel = new StudentModel())
            {

                Console.WriteLine("Enter Your StudentId:");
                int StudentId = Convert.ToInt32(Console.ReadLine());
                Student student = studentModel.Students.Where(x => x.StudentId == StudentId).FirstOrDefault();
                if (student != null)
                {
                    Console.WriteLine("Enter Your First Name:");
                    String StudentFirstName = Console.ReadLine();
                    Console.WriteLine("Enter Your Last Name:");
                    String StudentLastName = Console.ReadLine();
                    Console.WriteLine("Enter Your Gender:\n" + "1.Male\n" + "2.Female");
                    int Gender = Convert.ToInt32(Console.ReadLine());
                    string studentGender = " ";
                    if (Gender == 1)
                    {
                        studentGender = "Male";
                    }
                    if (Gender == 2)
                    {
                        studentGender = "Female";
                    }
                    Console.Write("Enter Your Choice:");

                    foreach (var data in studentModel.Courses)
                    {
                        Console.WriteLine(data.CourseId + " : " + data.CourseName);
                    }

                    int CourseId = Convert.ToInt32(Console.ReadLine());

                    student.StudentFirstName = StudentFirstName;
                    student.StudentLastName = StudentLastName;
                    student.StudentGender = studentGender;
                }
                else
                {
                    Console.WriteLine("StudentId is Not Found");
                    studentModel.SaveChanges();
                }

                studentModel.Students.Add(student);
                studentModel.SaveChanges();
            }

        }
        private void StudentDelete()
        {
            using (StudentModel studentModel = new StudentModel())
            {
                Console.WriteLine("Enter Your StudentId:");
                int studentId = Convert.ToInt32(Console.ReadLine());
                Student student = studentModel.Students.Where(x => x.StudentId == studentId).FirstOrDefault();
                if (student != null)
                {
                    studentModel.Students.Remove(student);
                }
                else
                {
                    Console.WriteLine("StudentID is Not Found");
                   
                }
                studentModel.SaveChanges();
            }

        }
        private void ViewStudentData()
        {
            using (StudentModel studentModel = new StudentModel())
            {
                foreach (var data in studentModel.Students)
                {
                    Console.WriteLine(data.StudentId + "  " + data.StudentFirstName + "  " + data.StudentLastName + "  " + data.StudentGender + "  " + data.CourseId);
                }
            }
            

        }
    }
}



