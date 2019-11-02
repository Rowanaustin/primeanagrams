using System.Linq;
using NUnit.Framework;

namespace Anagramo.Tests
{
    public class PermutatorTests
    {
        [Test]
        public void TestPermuteSingleChar()
        {
            var input = "a".ToCharArray();
            var result = input.GetPermutations();

            foreach (var element in result)
            {
                var charArray = element.ToArray();
                string elementString = new string(charArray);

                Assert.That(elementString, Is.EqualTo("a") );
            }
        }


        [Test]
        public void TestPermuteTwoChars()
        {
            var input = "gg".ToCharArray();
            var result = input.GetPermutations();

            foreach (var element in result)
            {
                var charArray = element.ToArray();
                string elementString = new string(charArray);

                Assert.That(elementString, Is.EqualTo("gg") );
            }
        }
    }
}