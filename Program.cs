using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        }
    }
}
