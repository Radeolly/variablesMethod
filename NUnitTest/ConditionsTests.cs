using NUnit.Framework;
using Library;

namespace NUnitTest
{
    public class ConditionsTests
    {
        [TestCase(5, 2, 7)]
        [TestCase(2, 2, 4)]
        [TestCase(-5, 100, -105)]
        public void SomeMath(int a, int b, int expected)
        {
            double actual = Conditions.SomeMath(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 2, 1)]
        [TestCase(-5, 2, 2)]
        [TestCase(-5, -2, 3)]
        [TestCase(5, -2, 4)]
        public void FindPointQuater(int x, int y, int expected)
        {
            double actual = Conditions.FindPointQuater(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 1, new int[3] {1, 2, 3})]
        [TestCase(1, 2, 3, new int[3] {1, 2, 3})]
        [TestCase(2, 1, 3, new int[3] {1, 2, 3})]
        [TestCase(2, 2, 2, new int[3] {2, 2, 2})]
        public void Sort3numbersIncrease(int a, int b, int c, int[] expected)
        {
            int[] actual = Conditions.Sort3numbersIncrease(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1, new double[1] {-1})]
        [TestCase(2, 5, -7, new double[2] {1, -3.5})]
        [TestCase(9, 6, 2, new double[0])]
        public void SolveQuadraticEquation(int a, int b, int c, double[] expected)
        {
            double[] actual = Conditions.SolveQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 5)]
        public void SolveQuadraticEquation(int a, int b, int c)
        {
            try
            {
                Conditions.SolveQuadraticEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(2, "два")]
        [TestCase(11, "одиннадцать")]
        [TestCase(23, "двадцать три")]
        [TestCase(95, "девяносто пять")]
        [TestCase(40, "сорок ")]
        public void WriteTwoDigitNumberInWords(int x, string expected)
        {
            string actual = Conditions.WriteTwoDigitNumberInWords(x);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(101)]
        [TestCase(100000)]
        [TestCase(0)]
        [TestCase(-10)]
        public void WriteTwoDigitNumberInWords(int x)
        {
            try
            {
                Conditions.WriteTwoDigitNumberInWords(x);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

    }
}