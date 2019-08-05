using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateBirthdate(DateTime.Now);
            }
            catch (NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            //GetStudentInformation();
            //GetTeacherInformation();
            //GetProgramInformation();
            //GetCourseInformation();
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter Student First name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Student Birthdate");
            string birthdate = Console.ReadLine();
            PrintStudentDetails(firstName,lastName,birthdate);
        }

        static void PrintStudentDetails(string first, string last, string birthdate)
        {
            Console.WriteLine($"{first} {last} was born on {Convert.ToDateTime(birthdate).ToString("dddd, dd MMMM yyyy")}");
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter Teacher First name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Teacher Last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Teacher Birthdate");
            string birthdate = Console.ReadLine();
            PrintTeacherDetails(firstName, lastName, birthdate);
        }

        static void PrintTeacherDetails(string firstName, string lastName, string birthdate)
        {
            Console.WriteLine($"Teacher {firstName} {lastName} was born on {Convert.ToDateTime(birthdate).ToString("dddd, dd MMMM yyyy")}");
        }

        static void GetProgramInformation()
        {
            Console.WriteLine("Enter Program name");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter Department Head's name");
            string  departmentHead = Console.ReadLine();
            
            Console.WriteLine("Enter Degree Name");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter Credits Required");
            int creditsRequired = Convert.ToInt32(Console.ReadLine());
            PrintProgramDetails(programName, departmentHead, degreeName, creditsRequired);
        }
        static void PrintProgramDetails(string programName, string departmentHead, string degreeName, int creditsRequired)
        {
            Console.WriteLine("You have entered the following information");
            Console.WriteLine($"Program name is {programName}");

            Console.WriteLine($"Department Head's name is {departmentHead}");

            //Console.WriteLine($"Degrees offered are {degrees}");

            Console.WriteLine($"Degree Name is {degreeName}");

            Console.WriteLine($"Required Credits are {creditsRequired}");
        }

        static void GetCourseInformation()
        {
            Console.WriteLine("Enter Course Name");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter Credits");
            string credits = Console.ReadLine();
            Console.WriteLine("Enter Duration in weeks");
            int durationWeeks = Convert.ToInt32(Console.ReadLine());
            PrintCourseDetails(courseName, credits, durationWeeks);
        }
        static void PrintCourseDetails(string courseName, string credits, int durationWeeks)
        {
            //Console.WriteLine($"Name of the course is {courseName}");
            //Console.WriteLine($"Credits is {credits}");
            //Console.WriteLine($"Course duration in weeks is {durationWeeks}");
        }

        static void ValidateBirthdate(DateTime birthdate)
        {
            throw new NotImplementedException();
        }
    }
}
