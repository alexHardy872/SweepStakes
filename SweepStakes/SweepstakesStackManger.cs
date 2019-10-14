using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManger : ISweepstakesManager
    {

        Stack<Sweepstakes> stack;
        // uses stack datastructure

         public SweepstakesStackManger()
        {
            stack = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
        }


        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("name");
            return sweepstakes;
        }

    }
}
