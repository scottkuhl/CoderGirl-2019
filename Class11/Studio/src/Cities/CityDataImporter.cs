using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Cities
{
    public class CityDataImporter
    {
        internal static List<City> LoadData()
        {

            List<string[]> rows = new List<string[]>();

            using (StreamReader reader = File.OpenText("city_data.csv"))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    string[] rowArrray = CSVRowToStringArray(line);
                    if (rowArrray.Length > 0)
                    {
                        rows.Add(rowArrray);
                    }
                }
            }

            string[] headers = rows[0];
            rows.Remove(headers);

            List<City> cities = new List<City>();

            /**
             * Parse each row array into a City object.
             * Assumes CSV column ordering: 
             *      name, state, size, population
             */
            foreach (string[] row in rows)
            {
                cities.Add(new City {
                    Name = row[0],
                    State = row[1],
                    Population = int.Parse(row[2]),
                    Area = double.Parse(row[3])

                });
            }

            return cities;   
        }


        /**
         * Parse a single line of a CSV file into a string array
         */
        private static string[] CSVRowToStringArray(string row, char fieldSeparator = ',', char stringSeparator = '\"')
        {
            bool isBetweenQuotes = false;
            StringBuilder valueBuilder = new StringBuilder();
            List<string> rowValues = new List<string>();

            // Loop through the row string one char at a time
            foreach (char c in row.ToCharArray())
            {
                if ((c == fieldSeparator && !isBetweenQuotes))
                {
                    rowValues.Add(valueBuilder.ToString());
                    valueBuilder.Clear();
                }
                else
                {
                    if (c == stringSeparator)
                    {
                        isBetweenQuotes = !isBetweenQuotes;
                    }
                    else
                    {
                        valueBuilder.Append(c);
                    }
                }
            }

            // Add the final value
            rowValues.Add(valueBuilder.ToString());
            valueBuilder.Clear();

            return rowValues.ToArray();
        }

    }
}
