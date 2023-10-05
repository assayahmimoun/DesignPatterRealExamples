using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatternTravel
{
    // Strategy Interface
    // The ITravelStrategy Interface declares the method GotoAirport that is common to all supported versions of the algorithm.
    // The Context is going to use this Strategy Interface to call the algorithm defined by Concrete Strategies.
    public interface ITravelStrategy
    {
        void GotoAirport();
    }
}
