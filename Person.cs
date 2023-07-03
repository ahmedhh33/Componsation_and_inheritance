using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componsation_and_inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string Name, int Age, string Address)
        {
            this.Name = Name;

            this.Age = Age;
            this.Address = Address;
        }
        public string GetPersonInfo()
        {
            return $" Person Name: {this.Name} Age : {this.Age} Adress : {this.Address} ";
        }

    }
    public class Student : Person
    {

        public string StudentId { get; set; }
        public string Grad { get; set; }
        List <Course> StudentCourses { get; set; }
        public Student(string Name, int Age, string Address, string StudentId, string grad) : base(Name, Age, Address)
        {
            this.StudentId = StudentId;
            this.Grad = grad;
            StudentCourses = new List <Course>();
        }
        public void GetStudentInfo()
        {
            Console.WriteLine(" Students Details");
            Console.WriteLine($" Student Name: {this.Name} || Age : {this.Age} || Adress : {this.Address} || StufentID : {this.StudentId} || Grad : {this.Grad} ");
            Console.WriteLine("Corses that student enrolled in it are ");
            foreach(Course course in StudentCourses) 
            {
                Console.WriteLine(course.Title);
            }
            Console.WriteLine();
        }
        public void EnrollingStudentInCourses(Course InrolCourse)
        {
            StudentCourses.Add(InrolCourse);
        }
    }

    public class Teacher : Person
    {


        public string TeacherId { get; set; }
        public List <string> TeacherSubjects { get; set; }
        public Teacher(string Name, int Age, string Address, string TeacherId, List<string> TeacherSubjects) : base(Name, Age, Address)
        {
            this.TeacherId = TeacherId;
            this.TeacherSubjects = TeacherSubjects;
        }
        public void GetTeacherInfo()
        {
            Console.WriteLine( $" Teacher Name: {this.Name} || Age : {this.Age} || Adress : {this.Address} || StufentID : {this.TeacherId} ");
            Console.WriteLine("The Subjects that assigned to teacger are : ");
            foreach(string assignedsubject in TeacherSubjects)
            {
                Console.WriteLine(assignedsubject);
            }
            Console.WriteLine();
        }
        public void AssignSubject(List<string> subjects)
        {
            TeacherSubjects=subjects;
        }
    }

    public class Course
    {
        public string CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Teacher CourseTeacher { get; set; }//if the parameter is class dosenot need to be added to constructoor

        public Course (string CourseId, string Title, string Description)
        {
            this.CourseId = CourseId;
            this.Title = Title;
            this.Description = Description;
        }

        public void GetCourseinfo()
        {
            Console.WriteLine($"CoueseID: {this.CourseId} || Title: {this.Title} || Course Descriptions: {this.Description} ");
            Console.WriteLine("Assigned Teacher: " + (CourseTeacher != null ? CourseTeacher.Name : "Not assigned"));//all exeptions must be in the brakets
            Console.WriteLine();
        }

        public void AssignTeacherToCourse(Teacher assigneteacher)
        {
            CourseTeacher=assigneteacher;
        }
    }
}
