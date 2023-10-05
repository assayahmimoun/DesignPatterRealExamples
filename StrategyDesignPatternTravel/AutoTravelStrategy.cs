using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternTravel
{
    // Concrete Strategy A
    // The following AutoTravelStrategy Concrete Strategy implement the ITravelStrategy Interface and 
    // Implement the GotoAirport Method. 
    public class AutoTravelStrategy : ITravelStrategy
    {
        public void GotoAirport()
        {
            Console.WriteLine("Traveler is going to Airport by Auto and will be charged Rs 600");
        }
    }
}
