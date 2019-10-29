﻿using NUnit.Framework;

namespace Anagramo.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void TestAdd()
        {

            int a = 5;
            int b = 3;
            int exp = 8;

            Assert.That(Calculator.Add(a,b), Is.EqualTo(exp));
        }
        
        [Test]
        public void TestFactorialZero()
        {
            int a = 0;
            int b = 0;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }
        
        [Test]
        public void TestFactorialOne()
        {
            int a = 1;
            int b = 1;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialTwo()
        {
            int a = 2;
            int b = 2;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialThree()
        {
            int a = 3;
            int b = 6;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFour()
        {
            int a = 4;
            int b = 24;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFive()
        {
            int a = 5;
            int b = 120;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }

        [Test]
        public void TestFactorialFiftyReturnsZero()
        {
            int a = 50;
            int b = 0;

            Assert.That(Calculator.GenerateFactorial(a), Is.EqualTo(b));
            
        }
    }
}