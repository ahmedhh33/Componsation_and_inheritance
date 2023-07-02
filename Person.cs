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
        public Student(string Name, int Age, string Address, string StudentId, string grad) : base(Name, Age, Address)
        {
            this.StudentId = StudentId;
            this.Grad = grad;
        }
        public string GetStudentInfo()
        {
            return $" Person Name: {this.Name} Age : {this.Age} Adress : {this.Address} StufentID : {this.StudentId} Grad : {this.Grad} ";
        }
    }

    public class Teacher : Person
    {


        public string TeacherId { get; set; }
        public string Subjects { get; set; }
        public Teacher(string Name, int Age, string Address, string TeacherId, string Subjects) : base(Name, Age, Address)
        {
            this.TeacherId = TeacherId;
            this.Subjects = Subjects;
        }
        public string GetTeacherInfo()
        {
            return $" Person Name: {this.Name} Age : {this.Age} Adress : {this.Address} StufentID : {this.TeacherId} Grad : {this.Subjects} ";
        }
    }

    public class Course
    {
        public string CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        Teacher TeacherId { get; set; }

        public Course (string CourseId, string Title, string Description, Teacher TeacherId)
        {
            this.CourseId = CourseId;
            this.Title = Title;
            this.Description = Description;

        }
    }
}
