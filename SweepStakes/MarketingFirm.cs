using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SweepStakes
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        bool quit;

    public MarketingFirm(ISweepstakesManager manager)
    {
            this.manager = manager;
            quit = false;
    }



    public void Menu()
        {
            do
            {
                UI.MarketingFirmMenu();
                MenuSelection(UI.ValidateMFMenuSelection());
            }
            while (quit == false);
            ExitApplication();
        }

        public void MenuSelection(string selection)
        {
            switch (selection)
            {
                case "G":
                    Sweepstakes tmp = manager.GetSweepstakes();
                    tmp.Menu();
                    break;
                case "S":
                    CreateSweepstakes();
                    break;
                case "E":
                    quit = true;
                    break;
            }
        }


    public void ExitApplication()
        {
            Environment.Exit(0);
        }

    public void CreateSweepstakes() 
        {
            string nameOfSweepstakes = UI.GetUserInput("Please name your sweepstakes");
            Sweepstakes sweepstakes = new Sweepstakes(nameOfSweepstakes);
            sweepstakes.Menu();
            manager.InsertSweepstakes(sweepstakes);
            
        }




    }
}
