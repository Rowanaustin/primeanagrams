using NUnit.Framework;

namespace Anagramo.Tests
{
    public class UtilTests
    {        
        [Test]
        public void TestFactorialZero()
        {
            int a = 0;
            int b = 1;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }
        
        [Test]
        public void TestFactorialOne()
        {
            int a = 1;
            int b = 1;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialTwo()
        {
            int a = 2;
            int b = 2;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialThree()
        {
            int a = 3;
            int b = 6;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFour()
        {
            int a = 4;
            int b = 24;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFive()
        {
            int a = 5;
            int b = 120;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialTwelve()
        {
            int a = 12;
            int b = 479001600;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
        }

        [Test]
        public void TestFactorialThirteenReturnsZero()
        {
            int a = 13;
            int b = 0;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
        }

        [Test]
        public void TestStringSwap1()
        {
            string a = "ab";
            string b = "ba";
            int inta = 0;
            int intb = 1;

            Assert.That(a.SwapChars(inta,intb), Is.EqualTo(b));
        }

        [Test]
        public void TestStringSwap2()
        {
            string a = "rowanaustinhaha";
            string b = "nowanaustirhaha";
            int inta = 0;
            int intb = 10;

            Assert.That(a.SwapChars(inta,intb), Is.EqualTo(b));
        }

        [Test]
        public void UppercaseBecomesLowercase()
        {
            string input = "AbCdefGG";
            string expt = "abcdefgg";
            
            Assert.That(Util.CleanWordInput(input), Is.EqualTo(expt));
        }
        
        [Test]
        public void NonAlphaCharactersRemoved()
        {
            string input = "Ab1C2de f;;=>G,G";
            string expt = "abcdefgg";
            
            Assert.That(Util.CleanWordInput(input), Is.EqualTo(expt));
        }

        [Test]
        public void ApostropheRemoved()
        {
            string input = "as'you'see";
            string expt = "asyousee";
            
            Assert.That(Util.CleanWordInput(input), Is.EqualTo(expt));
        }
    }
}