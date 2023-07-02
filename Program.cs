namespace Componsation_and_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entring studens objects
            Student std1 = new Student("Ahmed",22,"Musalla","u11223","C+");
            Student std2 = new Student("Saleh", 33, "AL-Aamirate","s12321","A");
            //entring teather objects
            Teacher teacher1 = new Teacher("Alkindy",65,"Canada","et3443",new List<string> { "Islamic Culture", "Arabic1","Filasufic"});//composation
            Teacher teacher2 = new Teacher("Hassan",34,"Matrah","rt65654",new List<string> { "EM1","EM2", "High Voltage" });
            // entring coureses
            Course course1 = new Course("ECE345", "Higt Voltage", "Electrical Power advanciced");
            Course course2 = new Course("ARE356","Isalmic Culture", "Islamic cultur in oman ");

            std1.GetStudentInfo();//printing student information
            std2.GetStudentInfo();
            Console.WriteLine("********");

            teacher1.GetTeacherInfo();//printing teacher info
            teacher2.GetTeacherInfo();
            Console.WriteLine("********");

            course1.GetCourseinfo();//Displaying course details
            course2.GetCourseinfo();
            Console.WriteLine("********");

            std1.EnrollingStudentInCourses(course1 );// Enrolling students in courses
            std1.EnrollingStudentInCourses(course2);
            std2.EnrollingStudentInCourses(course2 );

            Console.WriteLine("printing student information after enroliing in courses");
            std1.GetStudentInfo();//printing student information after enroliing in courses
            std2.GetStudentInfo();
            Console.WriteLine("********");

            course1.AssignTeacherToCourse(teacher2 );// Assigning teachers to courses
            course2.AssignTeacherToCourse(teacher1 );

            Console.WriteLine("Displaying course details after assigning teachers to them");
            course1.GetCourseinfo();//Displaying course details
            course2.GetCourseinfo();
            Console.WriteLine("********");


        }
    }
}