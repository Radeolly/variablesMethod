using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    static public class Array2D
    {
        static public int[,] FillTheArrayWithRandomNumbers(int KolvoStrok, int KolvoStolbcov)
        {
            int[,] a = new int[KolvoStrok, KolvoStolbcov];
            Random r = new Random();

            for (int i = 0; i < KolvoStrok; i++)
            {
                for (int j = 0; j < KolvoStolbcov; j++)
                {
                    a[i, j] = r.Next(0, 9);
                }
            }
            return a;
        }

        static public void WriteArray(int[,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static public int[,] CopyArray(int[,] array)
        {
            int[,] b = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    b[i, j] = array[i, j];
                }
            }
            return b;
        }

        static public int GetMinElement(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        static public int[] GetIndexOfArrayMinElement(int[,] array)
        {
            int min = array[0, 0];
            int[] IndexMin = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        IndexMin[0] = i;
                        IndexMin[1] = j;
                    }
                }
            }
            return IndexMin;
        }

        static public int GetMaxElement(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        static public int[] GetIndexOfArrayMaxElement(int[,] array)
        {
            int max = array[0, 0];
            int[] IndexMax = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        IndexMax[0] = i;
                        IndexMax[1] = j;
                    }
                }
            }
            return IndexMax;
        }

        static public int[,] RotateTheArrayAroundDiagonal(int[,] array)
        {
            int[,] b = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    b[j, i] = array[i, j];
                }
            }
            return b;
        }

        static public int FindTheNumberOfElementsThatAreGreaterThanAllTheirNeighbors(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i - 1 < 0 || array[i, j] > array[i - 1, j]) &&
                        (j - 1 < 0 || array[i, j] > array[i, j - 1]) &&
                        (i + 1 >= array.GetLength(0) || array[i, j] > array[i + 1, j]) &&
                        (j + 1 >= array.GetLength(1) || array[i, j] > array[i, j + 1]))
                    {
                        count++;
                        //Console.WriteLine($"элемент [{i},{j}] ");
                    }
                }
            }
            return count;
        }
    }
}
