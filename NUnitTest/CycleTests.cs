using NUnit.Framework;
using Library;

namespace NUnitTest
{
    public class CycleTests
    {
        [TestCase(1,2,1)]
        [TestCase(2,4,16)]
        [TestCase(5,0,1)]
        [TestCase(2,-1,0.5)]
        public void RaiseNumberToPower(int chislo, int stepen, double expected)
        {
            double actual = Cycle.RaiseNumberToPower(chislo, stepen);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, new int[8] { 125, 250, 375, 500, 625, 750, 875, 1000 })]
        [TestCase(250, new int[4] { 250, 500, 750, 1000 })]
        public void FindAllNumbersRfom1to1000ThatAreDivisibleByTheOriginal(int original, int[] expected)
        {
            int[] actual = Cycle.FindAllNumbersRfom1to1000ThatAreDivisibleByTheOriginal(original);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 3)]
        [TestCase(100, 10)]
        public void FindTheNumberOfPositiveNumbersWhoseSquareIsLessThanTheOriginal(int original, int expected)
        {
            int actual = Cycle.FindTheNumberOfPositiveNumbersWhoseSquareIsLessThanTheOriginal(original);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, 500)]
        [TestCase(125, 25)]
        [TestCase(17, 1)]
        public void FindTheGreatestDivisorOfNumber(int chislo, int expected)
        {
            int actual = Cycle.FindTheGreatestDivisorOfNumber(chislo);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 22, 35)]
        [TestCase(22, 10, 35)]
        [TestCase(14, 21, 35)]
        public void FindSummAllNumbersFromAtoBthatDivideTo7(int a, int b, int expected)
        {
            int actual = Cycle.FindSummAllNumbersFromAtoBthatDivideTo7(a,b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        public void FindFibonachiNumberN(int n, int expected)
        {
            int actual = Cycle.FindFibonachiNumberN(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(125, 25, 25)]
        [TestCase(150, 100, 50)]
        [TestCase(150, 150, 150)]
        public void FindLeastCommonDivisorForAandB(int a, int b, int expected)
        {
            int actual = Cycle.FindLeastCommonDivisorForAandB(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        public void FindNumberCubicRoot(int number, double expected)
        {
            double actual = Cycle.FindNumberCubicRoot(number);
            Assert.AreEqual(expected, actual, 1e-3);
        }

        [TestCase(8432, 1)]
        [TestCase(8, 0)]
        [TestCase(1115799, 7)]
        public void FindNumbersCountOddDigits(int number, int expected)
        {
            int actual = Cycle.FindNumbersCountOddDigits(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1115799, 9975111)]
        [TestCase(9, 9)]
        [TestCase(100, 1)]
        public void ReverseNumberDigits(int number, int expected)
        {
            int actual = Cycle.ReverseNumberDigits(number);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 4)]
        [TestCase(20, 9)]
        [TestCase(21, 10)]
        public void CountOfNumbersFrom1toNwhichSummEvenDigitsMoreThanSummOddDigits(int n, int expected)
        {
            int actual = Cycle.CountOfNumbersFrom1toNwhichSummEvenDigitsMoreThanSummOddDigits(n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(21, 25, true)]
        [TestCase(11589, 123, true)]
        [TestCase(11589, 623, false)]
        public void FindIfTwoNumbersHaveEqualDigits(int number1, int number2, bool expected)
        {
            bool actual = Cycle.FindIfTwoNumbersHaveEqualDigits(number1, number2);
            Assert.AreEqual(expected, actual);
        }


        //[TestCase(0, 0)]
        //[TestCase(100, 100)]
        //public void CountSomeEquation(int a, int b)
        //{
        //    try
        //    {
        //        Variables.CountSomeEquation(a, b);
        //    }
        //    catch
        //    {
        //        Assert.Pass();
        //    }
        //    Assert.Fail();
        //}

    }
}