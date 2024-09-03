using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDD_APP;


namespace TDD_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlusTest()
        {
            int number1 = 10;
            int number2 = 5;
            int expected = 15;
            Calculator calculator = new Calculator();
            int result = calculator.Plus(number1, number2);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void MinusTest()
        {
            int number1 = 20;
            int number2 = 3;
            int expected = 10;
            Calculator calculator = new Calculator();
            int result = calculator.Minus(number1, number2);
            Assert.AreEqual(expected, result); //<-- fail
        }
        
    }
}