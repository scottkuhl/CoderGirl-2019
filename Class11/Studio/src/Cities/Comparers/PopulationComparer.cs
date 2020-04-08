using System.Collections.Generic;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            if (x.Population < y.Population) return 1;
            if (x.Population == y.Population) return 0;
            return -1;
        }
    }
}
