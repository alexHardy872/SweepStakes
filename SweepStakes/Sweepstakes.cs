using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {

        
        public Dictionary<Contestant, int> contestants;
        public string name;
        public List<int> usedList;

        

        
        
            
        

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<Contestant, int>();
            this.name = name;
            usedList = new List<int>();
            
        }


        public void RegisterContestant(Contestant contestant)
        {
            UI.GetContestantInformation(contestant);
            contestant.registrationNumber = FindUniqueRegistrationNumber(contestant);
            contestants.Add(contestant, contestant.registrationNumber); // what key values?
            
        }

        public int FindUniqueRegistrationNumber(Contestant contestant)
        {
            int regNum;
            do
            {
                regNum = UI.GenerateRandomNumber(10000, 99999);
            }
            while (usedList.Contains(regNum));

            usedList.Add(regNum);

            return regNum;
        }


       // public Contestant PickWinner()
        //{
            // CHOOSE FROM LIST OF VALUES RANDOMLY
            // FIND CONTESTANT WITH THAT ID

            //return contestant;
       // }


        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplayContestantInformation(contestant);
        }











    }
}
