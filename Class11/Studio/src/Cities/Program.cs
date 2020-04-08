using Cities.Comparers;
using System;
using System.Collections.Generic;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            //IComparer<City> comparer = new AreaComparer();

            CompoundComparer comparer = new CompoundComparer();
            comparer.Comparers.Add(new StateComparer());
            comparer.Comparers.Add(new PopulationComparer());

            cities.Sort(comparer);

            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
