using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]

    public class CalculatorTests
    {
        private Calculator_Manual_Test.Calculator uut;
        [SetUp]

        public void Setup()
        {
            // Arrange 
            uut = new Calculator_Manual_Test.Calculator();
        }
        
        [TestCase(100,300,400)]
        public void ADD_TWO_INT_IS_400(double a, double b,double result)
        {
            
            // Act + Assert
            Assert.That(uut.Add(a,b),Is.EqualTo(result));
        }


    }
}