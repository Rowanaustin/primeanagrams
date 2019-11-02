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

        public void TestBanana()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            string testInput = "Banana";

            Assert.True(ourDictionary.isEnglishWord(testInput));

        }
    }
}
