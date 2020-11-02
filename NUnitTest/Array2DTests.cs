using NUnit.Framework;
using Library;
using System;

namespace NUnitTest
{
    public class Array2DTests
    {
        [TestCase(1,1)]
        [TestCase(2,2)]
        [TestCase(3,3)]
        public void RotateTheArrayAroundDiagonal(int arrayNumber, int expectedNumber)
        {
            int[,] expected = GetExpectedMock(expectedNumber);
            int[,] actual =Array2D.RotateTheArrayAroundDiagonal(GetArrayMock(arrayNumber));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2,1)]
        [TestCase(1,1)]
        [TestCase(3,0)]
        public void GetMinElement(int arrayNumber, int expected)
        {
            int[,] array = GetArrayMock(arrayNumber);
            int actual = Array2D.GetMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 9)]
        [TestCase(2, 6)]
        [TestCase(3, 2)]
        public void GetMaxElement(int arrayNumber, int expected)
        {
            int[,] array = GetArrayMock(arrayNumber);
            int actual = Array2D.GetMaxElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 0, 0 })]
        [TestCase(2, new int[2] { 0, 0 })]
        [TestCase(3, new int[2] { 0, 0 })]
        public void GetIndexOfArrayMinElement(int arrayNumber, int[] expected)
        {
            int[,] array = GetArrayMock(arrayNumber);
            int[] actual = Array2D.GetIndexOfArrayMinElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[2] { 2, 2 })]
        [TestCase(2, new int[2] { 1, 2 })]
        [TestCase(3, new int[2] { 0, 2 })]
        public void GetIndexOfArrayMaxElement(int arrayNumber, int[] expected)
        {
            int[,] array = GetArrayMock(arrayNumber);
            int[] actual = Array2D.GetIndexOfArrayMaxElement(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 1)]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        public void FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors(int arrayNumber, int expected)
        {
            int[,] array = GetArrayMock(arrayNumber);
            int actual = Array2D.FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors(array);
            Assert.AreEqual(expected, actual);
        }




        int[,] GetArrayMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,2,3 },
                        {4,5,6 },
                        {7,8,9 }
                    };
                case 2:
                    return new int[,]
                    {
                        {1,2,3 },
                        {4,5,6 }
                    };
                case 3:
                    return new int[,]
                    {
                        {0,1,2,1,0 },
                        {1,0,1,0,1 },
                        {0,2,2,1,0 }
                    };
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        int[,] GetExpectedMock(int n)
        {
            switch (n)
            {
                case 1:
                    return new int[,]
                    {
                        {1,4,7 },
                        {2,5,8 },
                        {3,6,9 }
                    };
                case 2:
                    return new int[,]
                    {
                        {1,4 },
                        {2,5 },
                        {3,6 }
                    };
                case 3:
                    return new int[,]
                    {
                        {0,1,0 },
                        {1,0,2 },
                        {2,1,2 },
                        {1,0,1 },
                        {0,1,0 }
                    };
                default:
                    throw new IndexOutOfRangeException();
            }
        }

    }
}