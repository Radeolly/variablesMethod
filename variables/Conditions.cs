using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    static public class Conditions
    {
        static public int SomeMath(int a, int b)
        {
            int c;
            if (a > b)
            {
                c = a + b;
            }
            else if (a == b)
            {
                c = a * b;
            }
            else
            {
                c = a - b;
            }
            return c;
        }

        static public int FindPointQuater(int x, int y)
        {
            int quater;
            if (x > 0 && y > 0)
            {
                quater = 1;
            }
            else if (x < 0 && y > 0)
            {
                quater = 2;
            }
            else if (x < 0 && y < 0)
            {
                quater = 3;
            }
            else
            {
                quater = 4;
            }
            return quater;
        }

        static public int[] Sort3numbersIncrease(int a, int b, int c)
        {
            int[] cc = new int[3];
            if (a < b && a < c)
            {
                cc[0] = a;
                if (b < c)
                {
                    cc[1] = b;
                    cc[2] = c;
                }
                else
                {
                    cc[1] = c;
                    cc[2] = b;
                }
            }
            else if (b < a && b < c)
            {
                cc[0] = b;
                if (a < c)
                {
                    cc[1] = a;
                    cc[2] = c;
                }
                else
                {
                    cc[1] = c;
                    cc[2] = a;
                }
            }
            else if (a < b)
            {
                cc[0] = c;
                cc[1] = a;
                cc[2] = b;
            }
            else
            {
                cc[0] = c;
                cc[1] = b;
                cc[2] = a;
            }
            return cc;
        }

        static public double[] SolveQuadraticEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("Parametr a cant be zero");
            }
            int discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                double[] answer = new double[0];
                return answer;
            }
            else if (discriminant == 0)
            {
                double x1 = -b / 2 / a;
                double[] answer = new double[1] { x1 };
                return answer;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / 2 / a;
                double x2 = (-b - Math.Sqrt(discriminant)) / 2 / a;
                double[] answer = new double[2] { x1, x2 };
                return answer;
            }
        }

        static public string WriteTwoDigitNumberInWords(int x)
        {
            if (x<1 || x>99)
            {
                throw new Exception("Number can be only between 1 and 99");
            }
            int f = x % 10;
            int d = x / 10;
            string a = "";
            switch (d)
            {
                case 1:
                    {
                        switch (x)
                        {
                            case 10:
                                a = "деcять";
                                break;
                            case 11:
                                a = "одиннадцать";
                                break;
                            case 12:
                                a = "двенадцать";
                                break;
                            case 13:
                                a = "тринадцать";
                                break;
                            case 14:
                                a = "четырнадцать";
                                break;
                            case 15:
                                a = "пятнадцать";
                                break;
                            case 16:
                                a = "шестнадцать";
                                break;
                            case 17:
                                a = "семнадцать";
                                break;
                            case 18:
                                a = "восемнадцать";
                                break;
                            case 19:
                                a = "девятнадцать";
                                break;
                            default:
                                break;
                        }
                        f = 0;
                        break;
                    }
                case 2:
                    a = "двадцать ";
                    break;
                case 3:
                    a = "тридцать ";
                    break;
                case 4:
                    a = "сорок ";
                    break;
                case 5:
                    a = "пятьдесят ";
                    break;
                case 6:
                    a = "шестьдесят ";
                    break;
                case 7:
                    a = "семьдесят ";
                    break;
                case 8:
                    a = "восемьдесят ";
                    break;
                case 9:
                    a = "девяносто ";
                    break;
                default:
                    break;
            }
            switch (f)
            {
                case 1:
                    a += "один";
                    break;
                case 2:
                    a += "два";
                    break;
                case 3:
                    a += "три";
                    break;
                case 4:
                    a += "четыре";
                    break;
                case 5:
                    a += "пять";
                    break;
                case 6:
                    a += "шесть";
                    break;
                case 7:
                    a += "семь";
                    break;
                case 8:
                    a += "восемь";
                    break;
                case 9:
                    a += "девять";
                    break;
                default:
                    break;

            }
            return a;
        }
    }
}
