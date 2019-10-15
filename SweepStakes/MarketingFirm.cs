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

    public MarketingFirm(ISweepstakesManager manager)
    {
            this.manager = manager;
    }







    public void CreateSweepStakes() // send to factory to build one
        {
            string nameOfSweepstakes = UI.GetUserInput("Please name your sweepstakes");
            Sweepstakes sweepstakes = new Sweepstakes(nameOfSweepstakes);

            manager.InsertSweepstakes(sweepstakes);
        }




    }
}
