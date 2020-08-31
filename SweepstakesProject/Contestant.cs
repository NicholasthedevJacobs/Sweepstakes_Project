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
        public Contestant()
        {
            firstName = IUserInterface.FirstName();
            lastName = IUserInterface.LastName();
            emailAddress = IUserInterface.Email();
            //Contestant contestant = IUserInterface.SetContestantDetails();
            
            registrationNumber = 0;
        }

        //member methods


    }
}
