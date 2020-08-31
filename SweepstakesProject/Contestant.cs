using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant 
    {
        //member variables
        string firstName;
        string lastName;
        string emailAddress;
        int registrationNumber;

        //constructor
        public Contestant(string firstName, string lastName, string emailAddress, int registrationNumber)
        {
            firstName = IUserInterface.FirstName();
            lastName = IUserInterface.LastName();
            emailAddress = IUserInterface.Email();
            registrationNumber = 0;
        }

        //member methods


    }
}
