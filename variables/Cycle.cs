using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    static public class Cycle
    {
        static public double RaiseNumberToPower(int chislo, int stepen)
        {
            double c = 1;
            if (stepen >= 0)
            {
                for (int i = 1; i <= stepen; i++)
                {
                    c = c * chislo;
                }
            }
            else
            {
                for (int i = 1; i <= -stepen; i++)
                {
                    c = c / chislo;
                }
            }
            return c;
        }

        static public int[] FindAllNumbersRfom1to1000ThatAreDivisibleByTheOriginal(int original)
        {
            int b = 0;
            int[] a = new int[1000 / original];
            for (int i = 1; i <= 1000; i++)
            {
                if (i % original == 0)
                {
                    a[b] = i;
                    b++;
                }
            }
            return a;
        }

        static public int FindTheNumberOfPositiveNumbersWhoseSquareIsLessThanTheOriginal(int original)
        {
            int b = 0; //счетчик
            int chislo = 1;
            while (chislo * chislo <= original)
            {
                b++;
                chislo++;
            }
            return b;
        }

        static public int FindTheGreatestDivisorOfNumber(int chislo)
        {
            int delitel = 0;
            int k = chislo / 2 + 1; //нет смысла проверять дальше
            for (int i = 1; i <= k; i++)
            {
                if (chislo % i == 0)
                {
                    delitel = i;
                }
            }
            return delitel;
        }

        static public int FindSummAllNumbersFromAtoBthatDivideTo7(int a, int b)
        {
            int sum = 0;
            if (b < a)
            {
                int buf = a;
                a = b;
                b = buf;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    //Console.Write($" {i} ");  //проверка
                    sum += i;
                }
            }
            return sum;
        }

        static public int FindFibonachiNumberN(int n)
        {
            int fibonachi1 = 1;
            int fibonachi2 = 1;
            int sum = 0;
            //1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233
            if (n > 2)
            {
                for (int i = 3; i <= n; i++)
                {
                    sum = fibonachi1 + fibonachi2;
                    fibonachi2 = fibonachi1;
                    fibonachi1 = sum;
                }
            }
            else if (n == 1 || n == 2)
            {
                sum = 1;
            }
            return sum;
        }

        static public int FindLeastCommonDivisorForAandB(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            int lcd = a + b;
            return lcd;
        }

        static public double FindNumberCubicRoot(int number)
        {
            double a, b = 0; //границы
            double eps = 1e-3; //погрешность
            double polovina;
            double kub;
            Console.WriteLine("ищем кубический корень введенного числа методом половинного деления");
            Console.WriteLine("введите число");
            a = number;
            do
            {
                polovina = (a + b) / 2;
                kub = polovina * polovina * polovina;
                if (kub > number)
                {
                    a = polovina;
                }
                else
                {
                    b = polovina;
                }
            }
            while (kub > number + eps || kub < number - eps);

            return polovina;
        }

        static public int FindNumbersCountOddDigits(int number)
        {
            int k = 0;
            int n2;
            int cifra;
            n2 = number;
            do
            {
                cifra = n2 % 10;
                if (cifra % 2 == 1)
                {
                    k++;
                }
                n2 /= 10;
            }
            while (n2 != 0);
            return k;
        }

        static public int ReverseNumberDigits(int number)
        {
            int k = number;
            int n2 = 0;
            int cifra;
            do
            {
                cifra = k % 10;
                n2 = n2 * 10 + cifra;
                k /= 10;
            }
            while (k != 0);

            return n2;
        }

        static public int CountOfNumbersFrom1toNwhichSummEvenDigitsMoreThanSummOddDigits(int n)
        {
            int kolvo = 0;
            int sumnech = 0, sumchet = 0;
            int cifra;
            int i2;
            for (int i = 1; i <= n; i++)
            {
                i2 = i;
                sumchet = 0;
                sumnech = 0;
                do
                {
                    cifra = i2 % 10;
                    if (cifra % 2 == 0)
                    {
                        sumchet += cifra;
                    }
                    else
                    {
                        sumnech += cifra;
                    }
                    i2 /= 10;
                }
                while (i2 != 0);
                if (sumnech < sumchet)
                {
                    kolvo++;
                    //Console.Write($" {i} "); //проверка
                }
            }
            return kolvo;
        }

        static public bool FindIfTwoNumbersHaveEqualDigits(int number1, int number2)
        {
            int p1, p2;
            int cifra1 = 0, cifra2 = 0;
            p1 = number1;
            p2 = number2;
            bool answer = false;
            while (p1 != 0)
            {
                cifra1 = p1 % 10;
                while (p2 != 0 && answer == false)
                {
                    cifra2 = p2 % 10;
                    //Console.Write($" {cifra2} ");//проверка
                    p2 /= 10;
                    if (cifra1 == cifra2)
                    {
                        answer = true;
                    }
                }
                p1 /= 10;
                p2 = number2;
            }
            return answer;
        }
    }
}
