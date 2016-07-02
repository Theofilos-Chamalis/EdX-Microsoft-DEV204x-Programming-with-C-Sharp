using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Module_Three_Solution
	{
		static void Main(string[] args)
		{
			string studentFirstName, studentLastName, studentBirthday;
			string teacherFirstName, teacherLastName, teacherSpecialty;
			string courseName, courseCode, uProgram;
			int teacherYearsOfTeaching;
			float degreeOnCourse;
			GetStudentInformation(out studentFirstName,out studentLastName,out studentBirthday);
			PrintStudentDetails(studentFirstName, studentLastName, studentBirthday);
			GetTeacherInformation(out teacherFirstName, out teacherLastName, out teacherSpecialty,out teacherYearsOfTeaching);
			PrintTeacherDetails(teacherFirstName, teacherLastName, teacherSpecialty, teacherYearsOfTeaching);
			GetMiscInformation(out courseName, out courseCode, out uProgram, out degreeOnCourse);
			PrintMiscDetails(courseName, courseCode, uProgram, degreeOnCourse);
		}

		static void GetStudentInformation(out string studentFirstName, out string studentLastName, out string studentBirthday){
			Console.WriteLine("Enter the student's first name: ");
			studentFirstName = Console.ReadLine();
			Console.WriteLine("Enter the student's last name: ");
			studentLastName = Console.ReadLine();
			Console.WriteLine("Enter the student's birth date: ");
			studentBirthday = Console.ReadLine();
			try{
				validateStudentBirthday(studentBirthday);
			}
			catch (NotImplementedException e){
				Console.WriteLine("\nJust caught a notImplementedException!\n");
			}
			catch (Exception e) {
				Console.WriteLine("\nJust caught a more general Exception!\n");
			}
		}

		static void PrintStudentDetails(string first, string last, string birthday){
			Console.WriteLine("{0} {1} was born on: {2}\n===========================\n", first, last, birthday);
		}

		static void GetTeacherInformation(out string teacherFirstName, out string teacherLastName, out string teacherSpecialty,out int teacherYearsOfTeaching)
		{
			Console.WriteLine("Enter the teacher's first name: ");
			teacherFirstName = Console.ReadLine();
			Console.WriteLine("Enter the teacher's last name: ");
			teacherLastName = Console.ReadLine();
			Console.WriteLine("Enter the teacher's field of study: ");
			teacherSpecialty = Console.ReadLine();
			Console.WriteLine("Enter the teacher's years of experience: ");
			Int32.TryParse(Console.ReadLine(),out teacherYearsOfTeaching);
		}

		static void PrintTeacherDetails(string teacherFirstName, string teacherLastName, string teacherSpecialty, int teacherYearsOfTeaching)
		{
			Console.WriteLine("Teacher {0} {1} with the field of study of {2} has done {3} years of teaching \n===========================\n", teacherFirstName, teacherLastName, teacherSpecialty, teacherYearsOfTeaching);
		}

		static void GetMiscInformation(out string courseName, out string courseCode, out string uProgram, out float degreeOnCourse)
		{
			Console.WriteLine("Enter the course name: ");
			courseName = Console.ReadLine();
			Console.WriteLine("Enter the corresponding course code: ");
			courseCode = Console.ReadLine();
			Console.WriteLine("Enter the uProgram: ");
			uProgram = Console.ReadLine();
			Console.WriteLine("Enter the degree achieved by the student on this course: "); 
			float.TryParse(Console.ReadLine(), out degreeOnCourse);
		}

		static void PrintMiscDetails(string courseName, string courseCode, string uProgram, float degreeOnCourse)
		{
			Console.WriteLine("In the {1}: {0} course with the {2} uProgram, the above student scored a grade of {3} \n===========================\n", courseName, courseCode, uProgram, degreeOnCourse);
		}

		static void validateStudentBirthday(string studentBirthday) {
			throw new NotImplementedException();
		}

	}
}