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
            stack.Push(sweepstakes);
        }


        public Sweepstakes GetSweepstakes()
        {
            try
            {
               return stack.Pop();
            }
            catch
            {
               // UI.Error("no Sweepstakes in Stack");
                return null;
            }

        }

        public void ViewSweepstakes()
        {
            foreach (Sweepstakes sweepstakes in stack)
            {
                Console.WriteLine(sweepstakes.name + " (" + stack.Count + " contestants)");
            }
        }

    }
}
