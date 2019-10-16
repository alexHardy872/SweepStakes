using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SweepStakes
{
    public class Sweepstakes
    {

        
        public Dictionary<Contestant, int> contestants;
        public List<IContestant> subscribers;
        public string name;
        public List<int> usedList;
        public string winner;
        bool menuLoop = true;
        
        

        
        
            
        

        public Sweepstakes(string name)
        {
            contestants = new Dictionary<Contestant, int>();
            subscribers = new List<IContestant>();
            this.name = name;
            usedList = new List<int>();

            
        }


        public void RegisterContestant(Contestant contestant)
        {
            UI.GetContestantInformation(contestant);
            contestant.registrationNumber = FindUniqueRegistrationNumber();
            contestants.Add(contestant, contestant.registrationNumber);
            subscribers.Add(contestant); 
            
        }

        public int FindUniqueRegistrationNumber()
        {
            int regNum;
            do
            {
                regNum = UI.GenerateRandomNumber(10000, 100000);
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
                UI.DisplaySweepstakes(this);
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
               // case "W":
               //     PickWinner();
               //     menuLoop = false;
               //     break;
                case "D":
                    menuLoop = false;
                    break;
             
            }
        }

        public void GETMenu()
        {
            UI.DisplaySweepstakes(this);
            UI.GETSweepstakesMenu();
                GETMenuSelection(UI.GETSweepstakesMenuSelection());
           
        }

        public void GETMenuSelection(string selection)
        {
            UI.DisplaySweepstakes(this);
            switch (selection)
            {
                case "W":
                    PickWinner();
                    break;
                case "D":                
                    break;
            }
        }


        public Contestant PickWinner()
        {
            
            int winningNum = usedList[UI.GenerateRandomNumber(0, usedList.Count)];

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
            foreach (IContestant contestant in subscribers)
            {
                contestant.NotifyContestant(this.name);
            }
        }


        public void PrintContestantInfo(Contestant contestant)
        {
            UI.DisplaySweepstakes(this);
            Console.WriteLine("WINNER!");
            UI.DisplayContestantInformation(contestant);
            NotifyContestants();
        }











    }
}
