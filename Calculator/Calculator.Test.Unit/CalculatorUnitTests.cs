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
        [TestCase(22, 2, 24)]
        public void Add_Positiv_And_Negativ(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }

        [TestCase(-13, 2, -15)]
        [TestCase(-10, -20, 10)]
        [TestCase(22, 2, 20)]
        public void Subtract_Posivit_And_Negativ(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 2, 4)]
        [TestCase(-1, -5, 5)]
        [TestCase(22, 2, 44)]
        public void Multiply_Multiply_Positiv_And_Negativ(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(5, 3, 125)]
        [TestCase(2, -2, 0.25)]
        [TestCase(2, 20, 1048576)]
        public void Power_Positiv_And_Negativ(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(3, 3, 1)]
        [TestCase(4, 2, 2)]
        [TestCase(10, -5, -2)]
        public void Devide_Positiv_And_Negativ(double a, double b, double result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }

        [TestCase(4, 2)]
        [TestCase(100, 10)]
        [TestCase(900, 30)]
        public void Square_Root_Positiv(double a, double result)
        {
            Assert.That(_uut.Sqrt(a), Is.EqualTo(result));
        }

    }
}
