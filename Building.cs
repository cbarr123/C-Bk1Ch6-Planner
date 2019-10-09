using System;

namespace Planner
{
    public class Building
    {
        //Private Fields
        private string _designer = "Carl Barringer";
        private DateTime _dateConstructed = new DateTime();
        private string _address;
        private string _owner;
        //Public Properties
        public int Stories = 5;
        public double Width = 30;
        public double Depth = 50;
        public double Volume 
            {
                get 
                {
                    return Width * Depth * (3 * Stories);
                }
            }
        
        //Constructor for Building
        public Building (string address) 
        {
            _address = address;
        }


        //Public Methods
        public DateTime Construct() 
        {
            return _dateConstructed = DateTime.Now;
        }
        public void Purchase (string nameOfPurchaser)
        {
            _owner = nameOfPurchaser;
        }

        public void Print() 
        {
            Console.WriteLine(this._address);
            Console.WriteLine("------------------------");
            Console.WriteLine($"Designed by: {this._designer}");
            Console.WriteLine($"Constructed on {this._dateConstructed}");
            Console.WriteLine($"Owned by {this._owner}");
            Console.WriteLine($"{this.Volume} cubic meters of space");
            Console.WriteLine();
            

        }
    }
}