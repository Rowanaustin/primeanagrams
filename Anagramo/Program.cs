using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

//This line means that all of our "internal" classes are exposed to our Test project
//Notice that the Calculator class is internal - see what happens if you comment this line and try to build the solution
[assembly:InternalsVisibleTo("Anagramo.Tests")]
namespace Anagramo
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise class objects
            var myAlgorithm = new FactorGroupings();

            // Initialise containers
            var output = new List<List<string>>();
            var anagrammableFactors = new List<ulong>();
            var finalFactors = new List<ulong>();

            // Begin with user input
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine();

            var dict = new ComboDict(input); 

            // Initialise dictionary from file
            dict.AddBulkFromTextFile("./data/listOfWords.txt"); //See http://www.mieliestronk.com/wordlist.html
            
            // Find the product (the Key) and all the other factors of the input
            ulong bigNumber = ComboDict.GetComboKey(input);
            var allFactors =  Util.Factors(bigNumber);

            

            // Add the prime factors to the final list of all factors, and then also the non-prime factors, preserving prime duplicates
            // I just realised this might mean if there's four '2's we won't find the anagrams for (4,4) as well as (2,2,4)
            finalFactors = ComboDict.GetCharacterKeys(input);
            foreach (ulong fctr in allFactors)
            {
                if (!anagrammableFactors.Contains(fctr))
                {
                    finalFactors.Add(fctr);
                }
            }

            // Add the anagrammable factors to yet another List :)
            foreach (ulong fctr in finalFactors)
            {
                if (!(dict.GetWordsByKey(fctr)== null))
                {
                    anagrammableFactors.Add(fctr);
                }
            }

            // Find factor groupings which make multi-word anagrams of the original input
            var anagramKeys = myAlgorithm.GetFactorGroupings(anagrammableFactors, bigNumber);


            // Add the lists of ints to the output as lists of strings using dict
            // At the moment it just adds the first hit from the dictionary
            foreach (List<ulong> anagram in anagramKeys)
            {
                List<string> anagramWords = new List<string>();

                foreach (ulong k in anagram)
                {
                    anagramWords.Add(dict.GetFirstWordFromKey(k));
                }

                output.Add(anagramWords);

            }

            if (output.Count != 0)
            {
                Console.WriteLine("------------");
                Console.WriteLine("Matching words are:");

                Util.PrintListOfStringLists(output);
            }
            else
            {
                Console.WriteLine("No anagrams found.");
            }




        }
    }
}