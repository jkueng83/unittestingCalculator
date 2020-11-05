
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            Assert.AreEqual(calc.Calculate(2.2m, 1.1m, Calculator.models.CalculationType.ADDITION), 3.3m);
            Assert.AreEqual(calc.Calculate(2.2m, -1.1m, Calculator.models.CalculationType.ADDITION), 1.1m);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            Assert.AreEqual(calc.Calculate(2.2m, 1.1m, Calculator.models.CalculationType.SUBTRACTION), 1.1m);
            Assert.AreEqual(calc.Calculate(2.2m, -1.1m, Calculator.models.CalculationType.SUBTRACTION), 3.3m);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            Assert.AreEqual(calc.Calculate(2.0m, 2.0m, Calculator.models.CalculationType.MULTIPLICATION), 4.0m);
        }

        [TestMethod]
        public void TestDivison()
        {
            Calculator.models.Calculator calc = new Calculator.models.Calculator();
            Assert.AreEqual(calc.Calculate(4.4m, 2.2m, Calculator.models.CalculationType.DIVISTION), 2.0m);

            try
            {
                Assert.AreEqual(calc.Calculate(4.4m, 0.0m, Calculator.models.CalculationType.DIVISTION), 2.0m);
                Assert.Fail();
            }
            catch (DivideByZeroException ex)
            {
                Assert.IsTrue(true);
            }

        }

    }
}
