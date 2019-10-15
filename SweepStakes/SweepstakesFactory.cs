using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
     class SweepstakesFactory
    {
        public ISweepstakesManager CreateSweepstakesManager(String sweepstakesType)
        {
            ISweepstakesManager newSweepstakes;

            if ( sweepstakesType == "Q")
            {
                newSweepstakes =  new SweepstakesQueueManager();
                return newSweepstakes;
            }     
            else if  (sweepstakesType == "S")
            {
                newSweepstakes = new SweepstakesStackManager();
                return newSweepstakes;
            }
            else
            {
                return null;
            }       
        }

    }
}
