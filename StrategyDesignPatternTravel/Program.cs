namespace StrategyDesignPatternTravel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask the user to Select the Travel Type
            Console.WriteLine("Please Enter Travel Type : \n1 for Auto \n2 for Bus \n3 for Train \n4 for Taxi");
            int travelType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You Select Travel type : " + travelType);
            //Create an Instance of the TravelContext class
            TravelContext ctx = new TravelContext();
            //Based on the Travel Type Selected by user at Runtime,
            //Create the Appropriate Travel Instance and call the SetTravelStrategy method
            if (travelType == (int)TravelType.Bus)
            {
                ctx.SetTravelStrategy(new BusTravelStrategy());
            }
            else if (travelType == (int)TravelType.Train)
            {
                ctx.SetTravelStrategy(new TrainTravelStrategy());
            }
            else if (travelType == (int)TravelType.Taxi)
            {
                ctx.SetTravelStrategy(new TaxiTravelStrategy());
            }
            else if (travelType == (int)TravelType.Auto)
            {
                ctx.SetTravelStrategy(new AutoTravelStrategy());
            }
            else
            {
                Console.WriteLine("You Select an Invalid Option");
            }
            //Finally, call the GotoAirport Method
            ctx.GotoAirport();
            Console.Read();
        }
    }
}