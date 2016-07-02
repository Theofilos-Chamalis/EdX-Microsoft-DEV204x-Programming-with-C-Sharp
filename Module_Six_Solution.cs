using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Module_Six_Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing is done in main");
        }
    }



    class Person
    {
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        private string hairColor;

        public string HairColor
        {
            get { return hairColor; }
            set { hairColor = value; }
        }
    }



    class Student : Person
    {

        public Student(string fname, string lname, double weight, string hairColor)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Weight = weight;
            this.HairColor = hairColor;
            studentCounter += 1;
        }

        public Student()
        {
            studentCounter += 1;
        }

        public void TakeTest()
        {
            Console.WriteLine("The test was completed!");
        }

        private static int studentCounter = 0;

        public static int StudentCounter
        {
            get { return Student.studentCounter; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string birthday;

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string universityAttending;

        public string UniversityAttending
        {
            get { return universityAttending; }
            set { universityAttending = value; }
        }

        private bool enrolled;

        public bool Enrolled
        {
            get { return enrolled; }
            set { enrolled = value; }
        }
    }



    class Teacher : Person
    {

        public Teacher(string fname, string studies, double weight, string hairColor)
        {
            this.TeacherName = fname;
            this.TeacherFieldOfStudy = studies;
            this.Weight = weight + (0.2 * weight);
            this.HairColor = hairColor;
        }

        public Teacher()
        {

        }

        public void GradeTest()
        {
            Console.WriteLine("The test was graded!");
        }

        private string teacherName;

        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }

        private string teacherFieldOfStudy;

        public string TeacherFieldOfStudy
        {
            get { return teacherFieldOfStudy; }
            set { teacherFieldOfStudy = value; }
        }

        private int yearsOfExperience;

        public int YearsOfExperience
        {
            get { return yearsOfExperience; }
            set { yearsOfExperience = value; }
        }
    }
}