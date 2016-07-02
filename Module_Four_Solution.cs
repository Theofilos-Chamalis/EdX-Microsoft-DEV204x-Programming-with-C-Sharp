using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Module_Four_Solution
    {

        public struct Student
        {
            public Student(string firstName, string lastName, string birthday)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Birthday = birthday;
                this.universityAttending = "BBC";
                this.enrolled = true;
            }

            public string FirstName;
            public string LastName;
            public string Birthday;
            public string universityAttending;
            public bool enrolled;
        }

        public struct Teacher
        {
            public Teacher(string teacherName, string teacherFieldOfStudy, int yearsOfExperience)
            {
                this.TeacherName = teacherName;
                this.TeacherFieldOfStudy = teacherFieldOfStudy;
                this.YearsOfExperience = yearsOfExperience;

            }

            public string TeacherName;
            public string TeacherFieldOfStudy;
            public int YearsOfExperience;
        }

        public struct uProgram
        {
            public uProgram(string programTitle, double programCost)
            {
                this.ProgramTitle = programTitle;
                this.ProgramCost = programCost;
            }

            public string ProgramTitle;
            public double ProgramCost;
        }

        public struct Course
        {
            public Course(string courseName, int creditsEarned)
            {
                this.CourseName = courseName;
                this.CreditsEarned = creditsEarned;
            }

            public string CourseName;
            public int CreditsEarned;
        }

        static void Main(string[] args)
        {
            Student[] studentArray = new Student[5];
            studentArray[0] = new Student("Jeremy", "Clarckson", "20/2/1952");
            studentArray[1] = new Student("Richard", "Hammond", "11/4/1974");
            studentArray[2] = new Student("James", "May", "05/9/1960");
            studentArray[3] = new Student("The", "Stig", "31/2/1990");
            studentArray[4] = new Student("Swagger", "McYolowitz", "9/1/2000");

            studentArray[3].universityAttending = "his own";

            for (int i = 0; i < studentArray.GetLength(0); i++)
            {
                Console.WriteLine("{0} {1} was born in {2} \nand is attending in {3} university.\n", studentArray[i].FirstName, studentArray[i].LastName, studentArray[i].Birthday, studentArray[i].universityAttending);
            }
        }
    }
}