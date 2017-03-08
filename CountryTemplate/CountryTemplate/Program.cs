using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryTemplate
{
    class Program
    {
        static void Main(string[] args)

            
        {
           NewCountry.Name = "Cameroun";
           NewCountry.GeoLandMass = 475442;
           NewCountry.CollectionOfStates = 10;
           NewCountry.Population = 22250000;
           NewCountry.GDP = 29.570,000,000;
           NewCountry.President = "Paul Biya";

        }
    }
    class NewCountry
    {
         
        public string Name { get; set; }
        public int GeoLandMass { get; set; }
        public enum CollectionOfStates { get; set; }
        public long Population { get; set; }
        public long GDP { get; set; } 
        public string President { get; set; }

        public static char AddState (char Population, int landmass, int LGA);
    {
        return 
    }
 }
}
