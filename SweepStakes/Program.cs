using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {

         

            SweepstakesFactory factory = new SweepstakesFactory();
            string style = UI.GetManagerStyle();
            ISweepstakesManager manager = factory.CreateSweepstakesManager(style);
            MarketingFirm firm = new MarketingFirm(manager);



        }
    }
}
