using System.IO;

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

        
    }
}