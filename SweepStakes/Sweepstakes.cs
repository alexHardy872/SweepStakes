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
        public string winner;
        bool menuLoop = true;
        

        
        
            
        

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<Contestant, int>();
            this.name = name;
            usedList = new List<int>();

            
        }


        public void RegisterContestant(Contestant contestant)
        {
            UI.GetContestantInformation(contestant);
            contestant.registrationNumber = FindUniqueRegistrationNumber();
            contestants.Add(contestant, contestant.registrationNumber); 
            
        }

        public int FindUniqueRegistrationNumber()
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


        public void Menu()
        {
            menuLoop = true;
            do
            {
                UI.SweepstakesMenu();
                MenuSelection(UI.SweepstakesMenuSelection());
            }
            while (menuLoop == true);

        }

        public void MenuSelection(string selection)
        {
            switch (selection)
            {
                case "R":
                    Contestant contestant = new Contestant();
                    RegisterContestant(contestant);
                    break;
                case "W":
                    PickWinner();
                    menuLoop = false;
                    break;
                case "E":
                    menuLoop = false;
                    break;
             
            }
        }


        public Contestant PickWinner()
        {
            
            int winningNum = usedList[UI.GenerateRandomNumber(0, usedList.Count-1)];

            foreach (KeyValuePair<Contestant, int> contestant in contestants)
            {
                if (contestant.Value == winningNum)
                {
                    contestant.Key.isWinner = true;
                    winner = contestant.Key.firstName + " " + contestant.Key.lastName;
                    PrintContestantInfo(contestant.Key);
                    return contestant.Key;
                }      
                
            }

            return null;
        }

        public void NotifyContestants()
        {
            foreach (KeyValuePair<Contestant,int> contestant in contestants)
            {
                    contestant.Key.NotifyContestant();
            }
        }


        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplayContestantInformation(contestant);
        }











    }
}
