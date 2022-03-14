using NUnit.Framework;

namespace Check.Test
{
    public class Tests
    {
        [TestCase(2, 2, 6, 2)]
        [TestCase(9, 7, -20, -3)]
        [TestCase(18, -4, 32, 2)]
        public void DecideLinearEquationTest(int a, int b, int c, int expected)
        {
            int actual = Variables.DecideLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 4, 2, 0)]
        [TestCase(-15, 5, -3, 0)]
        [TestCase(135, 10, 13, 5)]
        public void MakeDivideTest(int a, int b, int expectedDivide, int expectedRemainder)
        {
            int actualDivide;
            int actualRemainder;
            Variables.MakeDivide(a, b, out actualDivide, out actualRemainder);
            Assert.AreEqual(expectedDivide, actualDivide);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        }
    }
}