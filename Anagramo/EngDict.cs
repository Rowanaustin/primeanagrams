using System.IO;

namespace Anagramo
{
    class EnglishDictionary
    {
        private string listOfWords = "Apple";
        
        public bool isEnglishWord(string input)
        {
                if (input == listOfWords)
                {return true;}
                else
                {return false;}

        }

        
    }
}