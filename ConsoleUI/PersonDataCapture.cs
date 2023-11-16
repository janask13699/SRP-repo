using SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            // Ask for user information
            Person output = new Person();

            Console.Write("What is your first name: ");
            output.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            output.LastName = Console.ReadLine();

            
            output.Email = $"{output.FirstName}{output.LastName}@twilightsoftwares.com";
            Console.WriteLine($"Your Email is:{ output.Email}");


            Console.WriteLine("Enter Your Gender: ");
            output.Gender = Console.ReadLine();

            return output;
        }
    }
}
