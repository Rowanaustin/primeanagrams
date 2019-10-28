using NUnit.Framework;

namespace Anagramo.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void TestAdd()
        {
            var calculator = new Calculator();

            int a = 5;
            int b = 3;
            int exp = 7;

            Assert.That(calculator.Add(a,b), Is.EqualTo(exp));
        }
    }
}