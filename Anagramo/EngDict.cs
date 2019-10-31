using System.IO;

namespace Anagramo
{
    class EnglishDictionary
    {
        private string[] listOfWords;
        public EnglishDictionary()
        {
            string[] listOfWords = new string[5]{"Apple", "Banana", "Codfruit", "Derling", "Elgar"};
        }
        public bool isEnglishWord(string input)
        {
            for (int i = 0; i < listOfWords.Length; i++)
            {
                if (input == listOfWords[i])
                {return true;}
            }
            return false;
        }

        
    }
}