using System.Linq;
using NUnit.Framework;

namespace Anagramo.Tests
{
    public class PermutatorTests
    {
        [Test]
        public void TestPermuteCharArray()
        {
            var input = "dog".ToCharArray();
            var result = input.GetPermutations();

            foreach (var element in result)
            {
                var charArray = element.ToArray();
                string elementString = new string(charArray);
            }

            Assert.Fail("Test is not fully implemented.");
        }
    }
}