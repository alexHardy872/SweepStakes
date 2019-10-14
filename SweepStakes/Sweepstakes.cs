using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {

        // dictionary
        public Dictionary<string, string> dictionary;
        public Random random;

        

        
        
            
        

        public Sweepstakes(string name)
        {
            dictionary = new Dictionary<string, string>();
            random = new Random();
        }


        public void RegisterContestant(Contestant contestant)
        {
            UI.GetContestantInformation(contestant, random);
            
        }


        public Contestant PickWinner()
        {
            Contestant contestant = new Contestant();
            return contestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }











    }
}
