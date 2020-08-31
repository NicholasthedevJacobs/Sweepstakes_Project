using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class IUserInterface
    {
        public static void SetContestantDetails()
        {           
            FirstName();
            LastName();
            Email();
            

        }
        public static string FirstName()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string LastName()
        {
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string Email()
        {
            Console.WriteLine("What is your email address?");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }

        public static void RegistrationNumber()
        {
            //perhaps make the registration number 1+ the count of users
        }
       
    }
}
