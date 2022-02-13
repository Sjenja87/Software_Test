using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(10, 1, 11)]
        [TestCase(15, -5, 10)]
        public void Add_Positiv_And_Negativ(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(-13, 2, -15)]
        [TestCase(-10, -20, 10)]
        public void Subtract_Posivit_And_Negativ(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 2, 4)]
        [TestCase(-1, -5, 5)]
        public void Multiply_Multiply_Positiv_And_Negativ(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(5, 3, 125)]
        [TestCase(2, -2, 0.25)]
        public void Power_Positiv_And_Negativ(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }
    }
}
