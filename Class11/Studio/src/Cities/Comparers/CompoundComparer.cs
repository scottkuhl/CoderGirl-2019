using System.Collections.Generic;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers { get; set; } = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            foreach (var comparer in Comparers)
            {
                var result = comparer.Compare(x, y);
                if (result != 0) return result;
            }
            return 0;
        }
    }
}
