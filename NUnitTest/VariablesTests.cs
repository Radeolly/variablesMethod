using NUnit.Framework;
using Library;

namespace NUnitTest
{
    public class VariablesTests
    {
        [TestCase(1,2,1)]
        [TestCase(2,1,-9)]
        [TestCase(1,0,-5)]
        [TestCase(0,1,-1)]
        public void CountSomeEquation(int a, int b, double expected)
        {
            double actual = Variables.CountSomeEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(100, 100)]
        public void CountSomeEquation(int a, int b)
        {
            try
            {
                Variables.CountSomeEquation(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(1, 2, 5, 3)]
        [TestCase(2, 6, 2, -2)]
        [TestCase(2, 6, 0, -3)]
        public void CountSimpleEquation(int a, int b, int c, double expected)
        {
            double actual = Variables.CountSimpleEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 100, 10)]
        public void CountSimpleEquation(int a, int b, int c)
        {
            try
            {
                Variables.CountSimpleEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(0, 0, 1, 1, "y=1x+0")]
        [TestCase(5, 1, 5, 2, "x=5")]
        [TestCase(1, 3, 4, 3, "y=3")]
        [TestCase(1, 2, 3, 4, "y=1x+1")]
        public void FindEquationByTwoPoints(int x1, int y1, int x2, int y2, string expected)
        {
            string actual = Variables.FindEquationByTwoPoints(x1, y1, x2, y2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 5, 1, 5)]
        public void FindEquationByTwoPoints(int x1, int y1, int x2, int y2)
        {
            try
            {
                Variables.FindEquationByTwoPoints(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [TestCase(4, 2, new int[2] {2, 0})]
        [TestCase(1, 2, new int[2] {0, 1})]
        [TestCase(20, 11, new int[2] {1, 9})]
        public void FindResultOfDelenieAndOstatok(int a, int b, int[] expected)
        {
            int[] actual = Variables.FindResultOfDelenieAndOstatok(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 0)]
        public void FindResultOfDelenieAndOstatok(int a, int b)
        {
            try
            {
                Variables.FindResultOfDelenieAndOstatok(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


    }
}