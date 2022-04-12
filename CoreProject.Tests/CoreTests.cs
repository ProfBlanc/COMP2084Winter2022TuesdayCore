using NUnit.Framework;
using System;

namespace CoreProject.Tests
{
    [TestFixture]
    public class CoreTests
    {
        Calculator calc;
        [SetUp]
        public void SetUp() {
            calc = new Calculator();
        }

        [TestCase]
        public void Test_Calculator_Addition_With_Two_Double_Values() {

            //Arrange
            Calculator c = new Calculator();
            double n1 = 5;
            double n2 = 10;
            double expectedValue = 15;
            //Act
            double result = c.Add(n1, n2);
            //Assert
            Assert.AreEqual(expectedValue, result);
        
        }

        [TestCase]
        public void Test_Calculator_Addition_With_One_Double_Value_And_One_Int_Value()
        {

            //Arrange
            Calculator c = new Calculator();
            double n1 = 5;
            int n2 = 15;
            double expectedValue = 20;
            //Act
            double result = c.Add(n1, n2);
            //Assert
            Assert.AreEqual(expectedValue, result);

        }

        [TestCase]
        public void Test_Calculator_Addition_With_Two_Int_Values()
        {

            //Arrange
            Calculator c = new Calculator();
            int n1 = 15;
            int n2 = 100;
            double expectedValue = 115;
            //Act
            double result = c.Add(n1, n2);
            //Assert
            Assert.AreEqual(expectedValue, result);

        }

        [TestCase(10, 25)]
        [TestCase(-5, -20)]
        public void Test_Calculator_Subtraction_With_Passed_Values(int n1, int n2)
        {

            //Arrange
            Calculator c = new Calculator();
            double expectedValue = n1 - n2;
            //Act
            double result = c.Sub(n1, n2);
            //Assert
            Assert.AreEqual(expectedValue, result);

        }
        [TestCase]
        public void Test_Calculator_Division_By_Zero_Exception() {

            Calculator c = new Calculator();
            //double result = c.Div(1, 0);
            Assert.Catch<DivideByZeroException>( () => c.Div(1, 0) );

        }

        [TestCase(1, 10)]
        [TestCase(100, -10)]
        public void Test_Calculator_Subtraction_Two_Double_Values(double n1, double n2) {

            double expected = n1 - n2;
            Assert.AreEqual(expected, calc.Sub(n1, n2));
        
        }


    }
}
