using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibraryTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AdditionTest()
        {
            //Arrange
            double firstValue = 10.5;
            double secondValue = 7.3;
            double expected = 17.8;

            //Act
            double actual = Calculator.Add(firstValue, secondValue);

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Not added correctly");
        }

        [TestMethod]
        public void AdditionTest1()
        {
            //Arrange
            double firstValue = -5.5;
            double secondValue = 9.1;
            double expected = 3.6;

            //Act
            double actual = Calculator.Add(firstValue, secondValue);

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Not added correctly");
        }

        [TestMethod]
        public void AdditionTest2()
        {
            //Arrange
            double firstValue = -11.4;
            double secondValue = -3.8;
            double expected = -15.2;

            //Act
            double actual = Calculator.Add(firstValue, secondValue);
            
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Not added correctly");
        }

        [TestMethod]
        public void SubtractionTest()
        {
            //Arrange
            double firstValue = 7.6;
            double secondValue = 5.2;
            double expected = 2.4;

            //Act
            double actual = Calculator.Subtract(firstValue, secondValue);

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Not subtracted correctly");
        }

        [TestMethod]
        public void SubtractionTest1()
        {
            //Arrange
            double firstValue = -8.3;
            double secondValue = 1.5;
            double expected = -9.8;

            //Act
            double actual = Calculator.Subtract(firstValue, secondValue);

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Not subtracted correctly");
        }

        [TestMethod]
        public void SubtractionTest2()
        {
            //Arrange
            double firstValue = -6.4;
            double secondValue = -5.5;
            double expected = -0.9;

            //Act
            double actual = Calculator.Subtract(firstValue, secondValue);

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Not subtracted correctly");
        }
    }
}
