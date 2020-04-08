using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities
{
    public class City
    {
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-24}{2,12}{3,10}", Name, State, Population, Area);
        }

        public static string GetTableHeader()
        {
            string row1 = string.Format("{0,-20}{1,-24}{2,-12}{3,-10}", "Name", "State", "Population", "Area (sq mi)");
            string row2 = new String('+', 64);
            return row1 + "\n" + row2;
        }
    }
}
