using System.Collections.Generic;

namespace Cities.Comparers
{
    public class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            // Since we want to sort strings, we can use the
            // comparer for the built-in string class
            return string.Compare(x.State, y.State);
        }
    }
}
