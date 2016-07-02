using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7 {
	class Module_Seven_Solution {
		static void Main(string[] args) {

			Student student1 = new Student("John","Travolta",52.2,"red");
			Student student2 = new Student("Jim", "Carrey",61.7,"blonde");
			Student student3 = new Student("Elton", "John",63.3,"black");

			for (int i = 0; i < 5; i++) {
				Random rndm = new Random();
				student1.Grades.Push(rndm.Next(1,100));
				student2.Grades.Push(rndm.Next(1, 100));
				student3.Grades.Push(rndm.Next(1, 100));
			}

			Course course1 = new Course();
			course1.CourseName = "Programming with C#";
			course1.StudentList.Add(student1);
			course1.StudentList.Add(student2);
			course1.StudentList.Add(student3);

			Teacher teacher1 = new Teacher("Nelson","Yoga",74.3,"brown");
			Teacher teacher2 = new Teacher("Michelle","Politics",85.4,"brown");

			course1.TeacherArray[0] = teacher1;
			course1.TeacherArray[1] = teacher2;

			Degree degree1 = new Degree("Bachelor of Computer Engineering");
			degree1.DegCourse = course1;

			UProgram program1 = new UProgram("Information Technology");

			program1.Degrees = degree1;

			Console.WriteLine("The {0} program contains the {1} degree\n",program1.ProgramTitle,program1.Degrees.DegreeType);
			Console.WriteLine("The {0} degree contains the course {1}\n", program1.Degrees.DegreeType, program1.Degrees.DegCourse.CourseName);
			Console.WriteLine("The {0} course contains {1} student(s)\n", program1.Degrees.DegCourse.CourseName, Student.StudentCounter);

			course1.ListStudents();
		}
	}



	class Student : Person {

		public Student(string fname, string lname, double weight, string hairColor) {
			this.FirstName = fname;
			this.LastName = lname;
			this.Weight = weight;
			this.HairColor = hairColor;
			studentCounter += 1;
		}

		public Student() {
			studentCounter += 1;
		}

		public void TakeTest() {
			Console.WriteLine("The test was completed!");
		}

		private static int studentCounter = 0;

		public static int StudentCounter {
			get { return Student.studentCounter; }
		}

		private Stack grades = new Stack();

		internal Stack Grades {
			get { return grades; }
			set { grades = value; }
		}

		private string firstName;

		public string FirstName {
			get { return firstName; }
			set { firstName = value; }
		}
		
		private string lastName;

		public string LastName {
			get { return lastName; }
			set { lastName = value; }
		}
		
		private string birthday;

		public string Birthday {
			get { return birthday; }
			set { birthday = value; }
		}
		
		private string universityAttending;

		public string UniversityAttending {
			get { return universityAttending; }
			set { universityAttending = value; }
		}
		private bool enrolled;

		public bool Enrolled {
			get { return enrolled; }
			set { enrolled = value; }
		}

	}

	

	class Teacher :Person{

		public Teacher(string fname, string studies, double weight, string hairColor) {
			this.TeacherName = fname;
			this.TeacherFieldOfStudy = studies;
			this.Weight = weight + (0.2*weight);
			this.HairColor = hairColor;
		}

		public Teacher() { 

		}

		public void GradeTest() {
			Console.WriteLine("The test was graded!");
		}

		private string teacherName;

		public string TeacherName {
			get { return teacherName; }
			set { teacherName = value; }
		}
		
		private string teacherFieldOfStudy;

		public string TeacherFieldOfStudy {
			get { return teacherFieldOfStudy; }
			set { teacherFieldOfStudy = value; }
		}
		
		private int yearsOfExperience;

		public int YearsOfExperience {
			get { return yearsOfExperience; }
			set { yearsOfExperience = value; }
		}
	}



	class UProgram {

		public UProgram(string title) {
			this.ProgramTitle = title;
		}

		public UProgram() { 

		}

		private string programTitle;

		public string ProgramTitle {
			get { return programTitle; }
			set { programTitle = value; }
		}
		
		private double programCost;

		public double ProgramCost {
			get { return programCost; }
			set { programCost = value; }
		}

		private Degree degrees = new Degree();

		internal Degree Degrees {
			get { return degrees; }
			set { degrees = value; }
		}
	}


	
	class Degree {

		public Degree(string type) {
			this.DegreeType = type;
		}

		public Degree() { 

		}

		private string degreeType;

		public string DegreeType {
			get { return degreeType; }
			set { degreeType = value; }
		}

		private Course degCourse = new Course();

		internal Course DegCourse {
			get { return degCourse; }
			set { degCourse = value; }
		}
	}



	class Course {
		
		private string courseName;

		public string CourseName {
			get { return courseName; }
			set { courseName = value; }
		}
		
		private int creditsEarned;

		public int CreditsEarned {
			get { return creditsEarned; }
			set { creditsEarned = value; }
		}

		//private Student[] studentArray = new Student[3];
		private ArrayList studentList = new ArrayList();

		internal ArrayList StudentList {
			get { return studentList; }
			set { studentList = value; }
		}

		public void ListStudents() {
			foreach (Student stdnt in StudentList) {
				Console.WriteLine("The first name of the student is {0} and the last {1}\n", stdnt.FirstName, stdnt.LastName);
			}
		}

		private Teacher[] teacherArray = new Teacher[3];

		internal Teacher[] TeacherArray {
			get { return teacherArray; }
			set { teacherArray = value; }
		}
	}


	
	class Person {
		
		private double weight;

		public double Weight {
			get { return weight; }
			set { weight = value; }
		}
		
		private string hairColor;

		public string HairColor {
			get { return hairColor; }
			set { hairColor = value; }
		}
	}
}