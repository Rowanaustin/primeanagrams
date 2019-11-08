using NUnit.Framework;

namespace Anagramo.Tests
{
    public class ComboDictTests
    {
        [Test]
        public void CanAddWord()
        {
            string word = "box";

            var dict = new ComboDict(word);
            dict.Add(word);
            ulong key = ComboDict.GetComboKey(word);
            
            Assert.That(dict.GetWordsByKey(key).Contains(word));
        }

        [Test]
        public void AnagrammaticWordsHaveSameKey()
        {
            string word1 = "god";
            string word2 = "dog";
            var dict = new ComboDict(word2);

            ulong key1 = ComboDict.GetComboKey(word1);
            ulong key2 = ComboDict.GetComboKey(word2);
            
            Assert.That(key1, Is.EqualTo(key2));
        }

        [Test]
        public void AnagrammaticWordsAreInSameList()
        {
            string word1 = "thread";
            string word2 = "hatred";
            var dict = new ComboDict(word1);
            dict.Add(word2);
            
            Assert.That(dict.GetWordsByWord(word1).Contains(word2));
        }

    }
}