using System;
using System.Runtime.CompilerServices;

//This line means that all of our "internal" classes are exposed to our Test project
//Notice that the Calculator class is internal - see what happens if you comment this line and try to build the solution
[assembly:InternalsVisibleTo("Anagramo.Tests")]
namespace Anagramo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new ComboDict();
            dict.AddBulkFromTextFile("./data/listOfWords.txt"); //Currently http://sherwoodschool.ru/vocabulary/proficiency/ 
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine();
            var output = dict.GetWordsByWord(input);
            if (output == null)
            {
                output = new System.Collections.Generic.List<string>(){"No matching words founds"};
            }

            Console.WriteLine("------------");
            Console.WriteLine("Matching words are:");
            Util.PrintStringCollection(output);
            
            
        }
    }
}