using NUnit.Framework;

namespace Anagramo.Tests
{
    public class UtilTests
    {        
        [Test]
        public void TestFactorialZero()
        {
            ulong a = 0;
            ulong b = 1;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }
        
        [Test]
        public void TestFactorialOne()
        {
            ulong a = 1;
            ulong b = 1;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialTwo()
        {
            ulong a = 2;
            ulong b = 2;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialThree()
        {
            ulong a = 3;
            ulong b = 6;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFour()
        {
            ulong a = 4;
            ulong b = 24;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFive()
        {
            ulong a = 5;
            ulong b = 120;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialTwelve()
        {
            ulong a = 12;
            ulong b = 479001600;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
        }

        [Test]
        public void TestFactorialThirteenReturnsZero()
        {
            ulong a = 13;
            ulong b = 0;

            Assert.That(Util.GenerateFactorial(a), Is.EqualTo(b));
        }

        [Test]
        public void TestStringSwap1()
        {
            string a = "ab";
            string b = "ba";
            ulong ulonga = 0;
            ulong ulongb = 1;

            Assert.That(a.SwapChars(ulonga,ulongb), Is.EqualTo(b));
        }

        [Test]
        public void TestStringSwap2()
        {
            string a = "rowanaustinhaha";
            string b = "nowanaustirhaha";
            ulong ulonga = 0;
            ulong ulongb = 10;

            Assert.That(a.SwapChars(ulonga,ulongb), Is.EqualTo(b));
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