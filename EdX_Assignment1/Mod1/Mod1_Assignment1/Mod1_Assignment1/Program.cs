using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is assignment for Module 1");

            
            string firstName;
            string lastName;
            string birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            long zipPostal;
            string country;
            string programName;
            string departmentHead;
            string degrees;
            string degreeName;
            string creditsRequired;
            string courseName;
            string credits;
            int durationWeeks;
            string teacher;

            Console.WriteLine("Enter Student First name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Student Last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Student Birthdate");
            birthdate = Console.ReadLine();
            Console.WriteLine("Enter Student Address Line 1");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter Student Address Line 2");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter Student City");
            city = Console.ReadLine();
            Console.WriteLine("Enter Student State/Province");
            stateProvince = Console.ReadLine();
            Console.WriteLine("Enter Student Zip/Postal");
            zipPostal = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Student Country");
            country = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("You have entered the following student information");
            Console.WriteLine();
            Console.WriteLine($"Student First name is {firstName}");
            
            Console.WriteLine($"Student Last name is {lastName}");
            
            Console.WriteLine($"Student Birthdate is {birthdate}");
           
            Console.WriteLine($"Student Address Line 1 is {addressLine1}");
            
            Console.WriteLine($"Student Address Line 2 is {addressLine2}");
            
            Console.WriteLine($"Student City is {city}");
            Console.WriteLine($"Student State/Province is {stateProvince}");
            Console.WriteLine($"Student Zip/Postal is {zipPostal}");
            Console.WriteLine($"Student Country is {country}");


            Console.WriteLine();

            Console.WriteLine("Enter Teacher's Information");
            Console.WriteLine();
            Console.WriteLine("Enter Teacher's First name");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Birthdate");
            birthdate = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Address Line 1");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Address Line 2");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter Teacher's City");
            city = Console.ReadLine();
            Console.WriteLine("Enter Teacher's State/Province");
            stateProvince = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Zip/Postal");
            zipPostal = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Teacher's Country");
            country = Console.ReadLine();

            Console.WriteLine("You have entered the following Teacher's information");
            Console.WriteLine($"Teacher's First name is {firstName}");
            
            Console.WriteLine($"Teacher's Last name is {lastName}");
            
            Console.WriteLine($"Teacher's Birthdate is {birthdate}");
           
            Console.WriteLine($"Teacher's Address Line 1 is {addressLine1}");
            
            Console.WriteLine($"Teacher's Address Line 2 is {addressLine2}");
            
            Console.WriteLine($"Teacher's City is {city}");
            Console.WriteLine($"Teacher's State/Province is {stateProvince}");
            Console.WriteLine($"Teacher's Zip/Postal is {zipPostal}");
            Console.WriteLine($"Teacher's Country is {country}");

            Console.WriteLine();

          

            Console.WriteLine();
            
            Console.WriteLine("Enter Program name");
            programName = Console.ReadLine();
            Console.WriteLine("Enter Department Head's name");
            departmentHead = Console.ReadLine();
            Console.WriteLine("Enter Degrees");
            degrees = Console.ReadLine();
            Console.WriteLine("Enter Degree Name");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter Credits Required");
            creditsRequired = Console.ReadLine();
            Console.WriteLine("Enter Course Name");
            courseName = Console.ReadLine();
            Console.WriteLine("Enter Credits");
            credits = Console.ReadLine();
            Console.WriteLine("Enter Duration in weeks");
            durationWeeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Teacher's Name");
            teacher = Console.ReadLine();

            Console.WriteLine("You have entered the following information");
            Console.WriteLine($"Program name is {programName}");

            Console.WriteLine($"Department Head's name is {departmentHead}");

            Console.WriteLine($"Degrees offered are {degrees}");

            Console.WriteLine($"Degree Name is {degreeName}");

            Console.WriteLine($"Required Credits are {creditsRequired}");

            Console.WriteLine($"Name of the course is {courseName}");
            Console.WriteLine($"Credits is {credits}");
            Console.WriteLine($"Course duration in weeks is {durationWeeks}");
            Console.WriteLine($"Teacher's name is {teacher}");
            Console.WriteLine();
        }
    }
}
