using NUnit.Framework;

namespace Anagramo.Tests
{
    public class DictionaryTests
    {
        [Test]
        public void TestApple()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            string testInput = "Apple";

            Assert.True(ourDictionary.isEnglishWord(testInput));

        }

        [Test]
        public void TestBanana()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            string testInput = "Banana";

            Assert.True(ourDictionary.isEnglishWord(testInput));

        }

        [Test]
        public void TestMissingWordABC()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            string testInput = "abc";

            Assert.False(ourDictionary.isEnglishWord(testInput));

        }
        
    }
}
