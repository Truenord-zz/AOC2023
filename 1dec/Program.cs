// See https://aka.ms/new-console-template for more information
using parser;
class Program
{
    static void Main(string[] args)
    {
        Parser parser = new Parser();
        Console.WriteLine(parser.ProcessFileLines());
    }
}