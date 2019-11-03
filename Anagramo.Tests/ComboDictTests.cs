using NUnit.Framework;

namespace Anagramo.Tests
{
    public class ComboDictTests
    {
        [Test]
        public void CreatesCorrectKeyForThreeLetterWord()
        {
            string word = "gym";
            int key = 61 * 53 * 43;


            Assert.That(ComboDict.GetComboKey(word), Is.EqualTo(key));
        }
        
        [Test]
        public void CreatesCorrectKeyForSixLetterWord()
        {
            string word = "weight";
            int key = 59 * 2 * 11 * 61 * 23 * 3;

            Assert.That(ComboDict.GetComboKey(word), Is.EqualTo(key));
        }

        [Test]
        public void CanAddWord()
        {
            string word = "box";
            int key = ComboDict.GetComboKey(word);
            var dict = new ComboDict();
            
            dict.Add(word);
            
            Assert.That(dict.GetWordsByKey(key).Contains(word));
        }

        [Test]
        public void AnagrammaticWordsHaveSameKey()
        {
            string word1 = "god";
            string word2 = "dog";
            var dict = new ComboDict();

            int key1 = ComboDict.GetComboKey(word1);
            int key2 = ComboDict.GetComboKey(word2);
            
            Assert.That(key1, Is.EqualTo(key2));
        }

        [Test]
        public void AnagrammaticWordsAreInSameList()
        {
            string word1 = "thread";
            string word2 = "hatred";
            var dict = new ComboDict();
            
            dict.Add(word1);
            dict.Add(word2);
            
            Assert.That(dict.GetWordsByWord(word1).Contains(word2));
        }
    }
}