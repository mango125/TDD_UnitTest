using ConsoleApp1;
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
            Assert.AreEqual(expected, result); // true
        }
        [TestMethod]
        public void MinusTest()
        {
            int number1 = 20;
            int number2 = 3;
            int expected = 10;
            Calculator calculator = new Calculator();
            int result = calculator.Minus(number1, number2);
            Assert.AreEqual(expected, result); // fail
        }
        [TestMethod]
        public void TrueTest()
        {
            DataType dataType = new DataType();
            bool result = dataType.CheckTrue(); // return true
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void FalseTest()
        {
            DataType dataType = new DataType();
            bool result = dataType.CheckFalse(); // return false
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void NullTest()
        {
            DataType dataType = new DataType();
            var result = dataType.CheckNull(); // return null
            Assert.IsNull(result);
        }
    }
}