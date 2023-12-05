using System;

namespace Parsers{
    // A parser class that extracts data from a .txt file, and loads it into an appropriate 
    // datastructure.

    class Parser{
        private string path = @"input.txt";

        public Parser(){
        }

        private string DataLoader(){
            String data = File.ReadAllText(path);
            return data;
        }

        private string[] SplitDataEntries(string data, char delimiter){
            return data.Split(delimiter);
        } 

        public string[] InitializeAndGetGames(){
            string data = DataLoader();
            return SplitDataEntries(data, ';');
        }
    }    
}
