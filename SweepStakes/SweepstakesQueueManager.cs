﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {

        // uses Queue as underlying datastructure
        public Queue<Sweepstakes> queue;


        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

     


        public Sweepstakes GetSweepstakes()
        {

            try
            {
                return queue.Dequeue();
            }
            catch
            {
              // UI.Error("no Sweepstakes in Queue");
                return null;
            }
                
        }

        public void ViewSweepstakes()
        {
            foreach (Sweepstakes sweepstakes in queue)
            {
                Console.WriteLine(sweepstakes.name + " (" + queue.Count + " contestants)");
            }

        }



    }
}
