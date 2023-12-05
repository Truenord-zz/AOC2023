using Parsers;
using Cubes;
using GameNamespace;
class Program
{
    static void Main(string[] args)
    {
        //Iinitalizing a parser and making each game an entry in an array.
        Parser parser = new Parser();
        string[] games = parser.InitializeAndGetGames();
        // We gotta set the settings of our allowed games:
        for (int i=0; i<games.Length; i++) {
           Console.WriteLine(games[i]);
          
        }
    }
}