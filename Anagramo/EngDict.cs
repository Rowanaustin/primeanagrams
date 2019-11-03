using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Anagramo
{
    class EnglishDictionary
    {
        private string[] listOfWords = {"Apple", "Banana", "Citron", "Dragonfruit"};
        
        public bool isEnglishWord(string input)
        {
            bool result = false;

            foreach (var element in listOfWords)
            {
                if (input == element)
                result = true;
            }
            
            return result;

        }

        public bool containsEnglishWord(IEnumerable<IEnumerable<char>> input)
        {
            foreach (var inputElement in input)
            {
                Console.WriteLine(inputElement.ToString());
                
                foreach (var realWord in listOfWords)
                {
                    var charArray = inputElement.ToArray();
                    string elementString = new string(charArray);
                    if (elementString == realWord)
                    return true;
                }
            }
            
            return false;

        }

        
    }
}