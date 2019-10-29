using NUnit.Framework;

namespace Anagramo.Tests
{
    public class CombinatorTests
    {
        [Test]
        public void TestOneLetter()
        {
            var combinator = new Combinator();

            string[] A = new string[1]{"a"};
            string B = "a";
            

            Assert.AreEqual(A,combinator.Combos(B));
        }
        [Test]
        public void TestTwoLetters()
        {
            var combinator = new Combinator();

            string[] A = new string[2]{"ab", "ba"};
            string B = "ab";

            Assert.AreEqual(A,combinator.Combos(B));
        }
        
    }

}