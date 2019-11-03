using NUnit.Framework;
using System.Linq;

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
        
        [Test]
        public void TestPermutationsReturnsTrue()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            /* This should return true for the word 'apple' */
            var testInput = "Aelpp".ToCharArray();
            var dictionaryInput = testInput.GetPermutations();

            Assert.True(ourDictionary.containsEnglishWord(dictionaryInput));

        }

        [Test]
        public void TestPermutationsReturnsFalse()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            var testInput = "Aelpx".ToCharArray();
            var dictionaryInput = testInput.GetPermutations();

            Assert.False(ourDictionary.containsEnglishWord(dictionaryInput));

        }

        [Test]
        public void TestPermutationsBanana()
        {
            EnglishDictionary ourDictionary = new EnglishDictionary();
            var testInput = "ananab".ToCharArray();
            var dictionaryInput = testInput.GetPermutations();

            Assert.False(ourDictionary.containsEnglishWord(dictionaryInput));

        }
    }
}
