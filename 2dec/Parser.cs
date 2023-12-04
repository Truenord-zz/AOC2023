using System;

namespace Parsers{
    // A parser class that extracts data from a .txt file, and loads it into an appropriate 
    // datastructure.

    class Parser{
        private string path = @"input.txt";

/* The `public Parser()` constructor is creating a new instance of the `Parser` class. Inside the
constructor, it calls the `DataLoader()` method to load the contents of a file into a string
variable called `data`. Then, it calls the `SplitDataEntries()` method, passing in the `data` string
as a parameter, to split the data into an array of strings called `entries`. */
        public Parser(){
        }
    
        /// <summary>
        /// The function "DataLoader" reads the contents of a file and returns it as a string.
        /// </summary>
        /// <returns>
        /// The method `DataLoader` is returning a string.
        /// </returns>
        private string DataLoader(){
            String data = File.ReadAllText(path);
            return data;
        }

       /// <summary>
       /// The function "SplitDataEntries" takes a string input and splits it into an array of strings
       /// using a specified delimiter.
       /// </summary>
       /// <param name="data">The data parameter is a string that contains multiple data entries
       /// separated by a delimiter.</param>
        private string[] SplitDataEntries(string data, char delimiter){
            return data.Split(delimiter);
        } 

        /// <summary>
        /// The function initializes and retrieves a list of games from a data source.
        /// </summary>
        /// <returns>
        /// The method is returning an array of strings, which represents the games.
        /// </returns>
        public string[] InitializeAndGetGames(){
            string data = DataLoader();
            return SplitDataEntries(data, ';');
        }
    }    
}
