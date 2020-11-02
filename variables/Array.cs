using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    static public class Array
    {
        static public int[] FillTheArrayWithRandomNumbers(int dlina)
        {
            int[] a = new int[dlina];
            Random r = new Random();

            for (int i = 0; i < dlina; i++)
            {
                a[i] = r.Next(1, 100);
            }
            return a;
        }

        static public int[] CopyArray(int[] array)
        {
            int[] b = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                b[i] = array[i];
            }
            return b;
        }

        static public int GetMinElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static public int GetIndexOfArrayMinElement(int[] array)
        {
            int imin = 0;
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    imin = i;
                }
            }
            return imin;
        }

        static public int GetMaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static public int GetIndexOfArrayMaxElement(int[] array)
        {
            int imax = 0;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }
            }
            return imax;
        }

        static public int GetTheSumOfArrayElementsWithOddIndexes(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }

        static public int[] ReverseArray(int[] array)
        {
            int[] b = CopyArray(array);
            int buf;
            for (int i = 0; i < array.Length / 2; i++)
            {
                buf = b[i];
                b[i] = array[array.Length - 1 - i];
                b[array.Length - 1 - i] = buf;
            }
            return b;
        }

        static public int GetTheCountOfArrayOddElements(int[] array)
        {
            int kolvoNechetElem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    kolvoNechetElem++;
                }
            }
            return kolvoNechetElem;
        }

        static public int[] ShangeArrayHalfs(int[] array)
        {
            int[] b = CopyArray(array);
            int buf;
            int n = b.Length;
            int seredina= n / 2;
            int shag = (n + 1) / 2;
                        
            for (int i = 0; i < seredina; i++)
            {
                buf = b[i];
                b[i] = b[i+shag];
                b[i+shag] = buf;
            }
            
            return b;
        }

        static public int[] SortArrayIncrease(int[] array)
        {

            int[] b = CopyArray(array);
            int buf;
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 1; j < b.Length - i; j++)
                {
                    if (b[j - 1] > b[j])
                    {
                        buf = b[j - 1];
                        b[j - 1] = b[j];
                        b[j] = buf;
                    }
                }
            }
            return b;
        }

        static public int[] SortArrayDecrease(int[] array)
        {
            //вставками
            int[] b = CopyArray(array);
            int buf;
            for (int i = 1; i < b.Length; i++)
            {
                buf = b[i];
                int j;
                for (j = i - 1; j >= 0; j--)
                {
                    if (b[j] < buf)
                    {
                        b[j + 1] = b[j];
                    }
                    else
                    {
                        break;
                    }
                }
                b[j + 1] = buf;
            }
            return b;
        }

        static public void WriteArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();
        }
    }

}
