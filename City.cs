using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        private string _city;
        private int _yearEstablished;
        public string mayor{ get; set; }
        public List<Building> Buildings {get; set;}

        public City(string city, int year) 
        {
            _city = city;
            _yearEstablished = year;
            Buildings = new List<Building>();
        }
    }
}