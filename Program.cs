using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new city: megalopolis
            City Megalopolis = new City("Megalopolis", 2019);
            //Define the mayor
            Megalopolis.mayor = "The Mayor";

            //Building 1
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            //Give each building a width, height, and number of stories.
            Console.WriteLine(FiveOneTwoEight);
            FiveOneTwoEight.Stories = 6;
            FiveOneTwoEight.Width = 20;
            FiveOneTwoEight.Depth = 30;
            Double FiveOneTwoEightVolume = FiveOneTwoEight.Volume;
            //Construct each building
            FiveOneTwoEight.Construct();
            //Have business people in your city purchase each of your buildings
            FiveOneTwoEight.Purchase("John Vanderbilt");
            Megalopolis.Buildings.Add(FiveOneTwoEight);


            //Building 2
            Building OneTwoNine = new Building("129 10th Avenue");
            //Give each building a width, height, and number of stories.
            Console.WriteLine(OneTwoNine);
            OneTwoNine.Stories = 20;
            OneTwoNine.Width = 40;
            OneTwoNine.Depth = 40;
            Double OneTwoNineVolume = OneTwoNine.Volume;
            //Construct each building
            OneTwoNine.Construct();
            //Have business people in your city purchase each of your buildings
            OneTwoNine.Purchase("Tony Roger");
            Megalopolis.Buildings.Add(OneTwoNine);
        
            foreach (Building building in Megalopolis.Buildings)
            {
                building.Print();
            }
        
        }
    }
}
