using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Module_Five_Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nothing is done in main");
        }
    }

    
    class Student
    {

        public Student(string fname, string lname)
        {
            this.FirstName = fname;
            this.LastName = lname;
        }

        public Student()
        {

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



    class Teacher
    {

        public Teacher(string fname, string studies)
        {
            this.TeacherName = fname;
            this.TeacherFieldOfStudy = studies;
        }

        public Teacher()
        {

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



    class UProgram
    {

        public UProgram(string title)
        {
            this.ProgramTitle = title;
        }

        public UProgram()
        {

        }

        private string programTitle;

        public string ProgramTitle
        {
            get { return programTitle; }
            set { programTitle = value; }
        }

        private double programCost;

        public double ProgramCost
        {
            get { return programCost; }
            set { programCost = value; }
        }

        private Degree degrees = new Degree();

        internal Degree Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }
    }



    class Degree
    {

        public Degree(string type)
        {
            this.DegreeType = type;
        }

        public Degree()
        {

        }

        private string degreeType;

        public string DegreeType
        {
            get { return degreeType; }
            set { degreeType = value; }
        }

        private Course degCourse = new Course();

        internal Course DegCourse
        {
            get { return degCourse; }
            set { degCourse = value; }
        }
    }



    class Course
    {
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private int creditsEarned;

        public int CreditsEarned
        {
            get { return creditsEarned; }
            set { creditsEarned = value; }
        }

        private Student[] studentArray = new Student[3];

        internal Student[] StudentArray
        {
            get { return studentArray; }
            set { studentArray = value; }
        }

        private Teacher[] teacherArray = new Teacher[3];

        internal Teacher[] TeacherArray
        {
            get { return teacherArray; }
            set { teacherArray = value; }
        }
    }

    
}
