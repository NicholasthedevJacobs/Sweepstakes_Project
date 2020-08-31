using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contestant nick = new Contestant();
            string nick = "Nick";
            Sweepstakes sweepstakes = new Sweepstakes(nick);
            Contestant nicky = new Contestant();
            sweepstakes.RegisterContestant(nicky);
            sweepstakes.PrintContestantInfo(nicky);
            Console.ReadLine();
        }
    }
}
