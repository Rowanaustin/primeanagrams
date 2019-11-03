using NUnit.Framework;

namespace Anagramo.Tests
{
    public class ComboDictTests
    {
        public void CreatesCorrectKeyForThreeLetterWord()
        {
            string word = "Gym";
            int key = 61 * 53 * 43;


            Assert.That(ComboDict.GetComboKey(word) == key);
        }
        
        public void CreatesCorrectKeyForSixLetterWord()
        {
            string word = "Weight";
            int key = 59 * 2 * 11 * 61 * 23 * 3;

            Assert.That(ComboDict.GetComboKey(word) == key);
        }

        public void CanAddWord()
        {
            string word = "Box";
            int key = ComboDict.GetComboKey(word);
            var dict = new ComboDict();
            
            dict.Add(word);
            
            Assert.That(dict.GetWordsByKey(key).Contains(word));
        }

        public void AnagrammaticWordsHaveSameKey()
        {
            string word1 = "God";
            string word2 = "Dog";
            var dict = new ComboDict();

            int key1 = ComboDict.GetComboKey(word1);
            int key2 = ComboDict.GetComboKey(word2);
            
            Assert.That(key1 == key2);
        }

        public void AnagrammaticWordsAreInSameList()
        {
            string word1 = "Thread";
            string word2 = "Hatred";
            var dict = new ComboDict();
            
            dict.Add(word1);
            dict.Add(word2);
            
            Assert.That(dict.GetWordsByWord(word1).Contains(word2));
        }
    }
}