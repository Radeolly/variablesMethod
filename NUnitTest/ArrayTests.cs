using NUnit.Framework;
using Library;

namespace NUnitTest
{
    public class ArrayTests
    {
        [TestCase(new int[4] { 1, 2, 3, 4}, new int[4] { 1, 2, 3, 4 })]
        [TestCase(new int[2] { -1, 100}, new int[2] { -1, 100 })]
        [TestCase(new int[10] { 1, 2, 3, 4,10,9,8,7,6,5}, new int[10] { 1, 2, 3, 4, 10, 9, 8, 7, 6, 5 })]      
        public void CopyArray(int[] array, int[] expected)
        {
            int[] actual = Array.CopyArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[10] { 1, 2, 3, 4,0,9,8,7,6,5}, 0)]      
        [TestCase(new int[5] { -1, 12, -100, 45, 58}, -100)]      
        [TestCase(new int[5] { -1, 12, -1, 45, 58}, -1)]      
        public void GetMinElement(int[] array, int expected)
        {
            int actual = Array.GetMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { -1, 12, -1, 45, 58}, 0)]      
        [TestCase(new int[5] { -1, 12, -100, 45, 58}, 2)]      
        [TestCase(new int[10] { 1, 2, 3, 4,0,9,8,7,6,5}, 4)]      
        public void GetIndexOfArrayMinElement(int[] array, int expected)
        {
            int actual = Array.GetIndexOfArrayMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[10] { 1, 2, 3, 4, 0, 9, 8, 7, 6, 5 }, 9)]
        [TestCase(new int[5] { -1, 12, -100, 45, 58 }, 58)]
        [TestCase(new int[5] { -1, 102, -1, 45, 102 }, 102)]
        public void GetMaxElement(int[] array, int expected)
        {
            int actual = Array.GetMaxElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[10] { 1, 2, 3, 4, 0, 9, 8, 7, 6, 5 }, 5)]
        [TestCase(new int[5] { -1, 12, -100, 45, 58 }, 4)]
        [TestCase(new int[5] { -1, 102, -1, 45, 102 }, 1)]
        public void GetIndexOfArrayMaxElement(int[] array, int expected)
        {
            int actual = Array.GetIndexOfArrayMaxElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[10] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1}, 9)]
        [TestCase(new int[2] { 1, 2}, 2)]
        public void GetTheSumOfArrayElementsWithOddIndexes(int[] array, int expected)
        {
            int actual = Array.GetTheSumOfArrayElementsWithOddIndexes(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[4] { 4,3,2,1})]
        [TestCase(new int[2] { -1, 100 }, new int[2] {100,-1 })]
        [TestCase(new int[10] { 1, 2, 3, 4, 10, 9, 8, 7, 6, 5 }, new int[10] { 5,6,7,8,9,10,4,3,2,1})]
        public void ReverseArray(int[] array, int[] expected)
        {
            int[] actual = Array.ReverseArray(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[10] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1 }, 7)]
        [TestCase(new int[2] { 1, 2 }, 1)]
        public void GetTheCountOfArrayOddElements(int[] array, int expected)
        {
            int actual = Array.GetTheCountOfArrayOddElements(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, new int[5] { 4, 5, 3, 1, 2 })]
        [TestCase(new int[2] { -1, 100 }, new int[2] { 100, -1 })]
        [TestCase(new int[10] { 1, 2, 3, 4, 10, 9, 8, 7, 6, 5 }, new int[10] { 9, 8, 7, 6, 5, 1, 2, 3, 4, 10 })]
        public void ShangeArrayHalfs(int[] array, int[] expected)
        {
            int[] actual = Array.ShangeArrayHalfs(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 5, 4, 3, 2, 1  }, new int[5] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[2] { -1, 100 }, new int[2] { -1, 100 })]
        [TestCase(new int[10] { 6, 2, 3, 4, 10, 9, 8, 7, 1, 5 }, new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        public void SortArrayIncrease(int[] array, int[] expected)
        {
            int[] actual = Array.SortArrayIncrease(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, new int[5] {  5, 4, 3, 2, 1 })]
        [TestCase(new int[2] { -1, 100 }, new int[2] { 100, -1 })]
        [TestCase(new int[10] { 6, 2, 3, 4, 10, 9, 8, 7, 1, 5 }, new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        public void SortArrayDecrease(int[] array, int[] expected)
        {
            int[] actual = Array.SortArrayDecrease(array);
            Assert.AreEqual(expected, actual);
        }
        
    }
}