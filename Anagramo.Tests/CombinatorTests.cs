using NUnit.Framework;

namespace Anagramo.Tests
{
    public class CombinatorTests
    {
        [Test]
        public void TestOneLetter()
        {
            var combinator = new Combinator();

            string A = "a";
            string B = "a";

            Assert.AreEqual(A,combinator.combos(B));
        }
    
        
    }

}