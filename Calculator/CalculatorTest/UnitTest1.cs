using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class MathTest1
        {
            //Lommeregner calc = new Lommeregner();
            Calculator.Calculator calc = new Calculator.Calculator();
            [TestMethod]
            public void TestAdd()
            {
                Assert.AreEqual(3, calc.Add(1, 2));
            }

            [TestMethod]
            public void TestSubtract()
            {
                Assert.AreEqual(6, calc.Subtract(8, 2));
            }

            [TestMethod]
            public void TestDivide1()
            {
                Assert.AreEqual(4, calc.Divide(8, 2));
            }

            [TestMethod]
            public void TestDivide2()
            {
                Assert.AreEqual(2.67, Math.Round(calc.Divide(8, 3), 2));
            }

            [TestMethod]
            public void TestMultiply()
            {
                Assert.AreEqual(8, calc.Multiply(4, 2));
            }

        }

    }
}