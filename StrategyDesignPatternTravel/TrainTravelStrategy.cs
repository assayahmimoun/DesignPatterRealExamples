using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternTravel
{
    // Concrete Strategy B
    // The following TrainTravelStrategy Concrete Strategy implement the ITravelStrategy Interface and 
    // Implement the GotoAirport Method. 
    public class TrainTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Train and will be charged Rs 200");
        }
    }
}
