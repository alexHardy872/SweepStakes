using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
  
   public  class Contestant : IContestant
    {

        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;
        public bool isWinner;

        public Contestant()
        {

            isWinner = false;
        }


        public void NotifyContestant()
        {
            
            if (isWinner == true)
            {
                // EMAIL CONTESTANT
            }
            else
            {
                // EMAIL CONTESTANT WITH LOSS
            }

        }




    }
}
