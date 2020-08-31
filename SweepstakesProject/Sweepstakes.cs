using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        //member variables
        string name;
        private Dictionary<int, Contestant> contestants;
        //private List<Contestant> contestants1;

        //constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
            this.name = name;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {
            
            contestants.Add(contestants.Count + 1, contestant);
           
        }
        public Contestant PickWinner()
        {
            //create a RNG
             Contestant winner = contestants[1];
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }

    }
}
