using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int ProducedYear;

        public string GetMaximumSpeed()
        {
            return ($"{Brand} {Model} {ProducedYear} can run max at speed 220");
        }
    }
}
