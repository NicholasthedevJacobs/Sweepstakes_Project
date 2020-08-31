using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class IUserInterface
    {
        public static string FirstName()
        {
            Console.WriteLine("What is your first name?");
            return Console.ReadLine();
        }

        public static string LastName()
        {
            Console.WriteLine("What is your last name?");
            return Console.ReadLine();
        }

        public static string Email()
        {
            Console.WriteLine("What is your email address?");
            return Console.ReadLine();
        }

        public static void RegistrationNumber()
        {
            //perhaps make the registration number 1+ the count of users
        }
       
    }
}
