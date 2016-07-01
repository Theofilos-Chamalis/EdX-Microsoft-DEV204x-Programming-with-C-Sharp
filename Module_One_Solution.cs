using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Module_One_Solution
    {
        static void Main(string[] args)
        {
            string FirstName, LastName, AddressLine1, AddressLine2, City, State, Postal, Country;
            string ProgramName, DepartmentHead;
            float Degrees;
            string DegreeName;
            int CreditsRequired;
            string CourseName, Teacher;
            int Credits, DurationInWeeks;
            DateTime birthday;

            string continuePrompt = "yes";

            while (continuePrompt == "yes")
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("New Student\n");
                Console.Write("First Name : ");
                FirstName = Console.ReadLine();
                Console.Write("Last Name : ");
                LastName = Console.ReadLine();
                Console.Write("Country : ");
                Country = Console.ReadLine();
                Console.Write("City : ");
                City = Console.ReadLine();
                Console.WriteLine("\nYou are " + FirstName + " " + LastName + "\nand you are from " + City + ", " + Country + ".\n\nContinue? (yes/no)");
                continuePrompt = Console.ReadLine();
            }
        }
    }
}