using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {

        Stack<Sweepstakes> stack;
        // uses stack datastructure

         public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            // PUSH SWEEPSTAKES
        }

        public void RemoveSweepstakes(Sweepstakes sweepstakes)
        {
            // POP SWEEPSTAKES
        }



        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes("name");
            return sweepstakes;
        }

    }
}
