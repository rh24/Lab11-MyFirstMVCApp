using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_MyFirstMVCApp.Models
{
    public class TimePerson
    {
        // Properties for TimePerson object based on parsed CSV data
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Birth_Year { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }

        // This is a static method that is called once to parse the personOfTheYear.csv file. This is the business logic that turns the raw data into a TimePerson instance.
        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            // Create a new generic List collection that consists of TimePerson objects
            List<TimePerson> people = new List<TimePerson>();
            // Get the relative path of current directory
            string path = Environment.CurrentDirectory;
            // Create a new path with wwwroot and personOfTheYear.csv
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot\personOfTheYear.csv"));
            // Read each line of the .csv file and store as an array of strings
            string[] myFile = File.ReadAllLines(newPath);

            // Loop through the myFile string array containing data from personOfTheYear.csv and parse each line of the string to fit the each property of a new TimePerson object.
            for (int i = 1; i < myFile.Length; i++)
            {
                // Properties are split by comma in the .csv file
                // You can tell which index holds which property based on the first line in the .csv file.
                // Year,Honor,Name,Country,Birth Year,Death Year,Title,Category,Context
                // [0], [1], [2], [3], [4], [5], [6], [7], [8]
                string[] fields = myFile[i].Split(',');
                people.Add(new TimePerson
                {
                    Year = Convert.ToInt32(fields[0]),
                    Honor = fields[1],
                    Name = fields[2],
                    Country = fields[3],
                    Birth_Year = (fields[4] == "") ? 0 : Convert.ToInt32(fields[4]),
                    DeathYear = (fields[5] == "") ? 0 : Convert.ToInt32(fields[5]),
                    Title = fields[6],
                    Category = fields[7],
                    Context = fields[8],
                });
            }

            // From the List of TimePerson objects, use LINQ method syntax to grab the objects where their Year property is greater than or equal to the beginning of Year query paramater AND less than or equal to the endYear query param.
            List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();

            // Return the matching List subset of TimePerson objects
            return listofPeople;
        }
    }
}
a