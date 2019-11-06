﻿using System;
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
            var dict = new ComboDict(); 

            // Initialise containers
            var output = new List<List<string>>();
            var anagrammableFactors = new List<int>();
            var finalFactors = new List<int>();

            // Initialise dictionary from file
            dict.AddBulkFromTextFile("./data/listOfWords.txt"); //See http://www.mieliestronk.com/wordlist.html

            // Begin with user input
            Console.WriteLine("Enter a word");
            var input = Console.ReadLine();
            
            // Find the product (the Key) and all the other factors of the input
            int bigNumber = ComboDict.GetComboKey(input);
            var allFactors =  Util.Factors(bigNumber);

            

            // Add the prime factors to the final list of all factors, and then also the non-prime factors, preserving prime duplicates
            // I just realised this might mean if there's four '2's we won't find the anagrams for (4,4) as well as (2,2,4)
            finalFactors = ComboDict.GetCharacterKeys(input);
            foreach (int fctr in allFactors)
            {
                if (!anagrammableFactors.Contains(fctr))
                {
                    finalFactors.Add(fctr);
                }
            }

            // Add the anagrammable factors to yet another List :)
            foreach (int fctr in finalFactors)
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
            foreach (List<int> anagram in anagramKeys)
            {
                List<string> anagramWords = new List<string>();

                foreach (int k in anagram)
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