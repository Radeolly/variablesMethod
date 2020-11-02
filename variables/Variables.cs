using System;
using System.Data;
using System.Net.Http.Headers;
using System.Numerics;

namespace Library
{
    static public class Variables
    {
        static public double CountSomeEquation(int a, int b)
        {
            if (a == b)
            {
                throw new Exception("Parametrs a and b cant be equal");
            }
            double c = (5 * a - b * b) / (b - a);
            return c;
        }

        static public double CountSimpleEquation(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new Exception("Parametr a cant be zero");
            }
            double x = (c - b) / a;
            return x;
        }

        static public string FindEquationByTwoPoints(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1==y2)
            {
                throw new Exception("Points cant be equal!");
            }
            double a;
            double b;
            string c;
            if (x1!=x2 && y1 != y2)
            {
            a= (y2 - y1) / (x2 - x1);
            b = y2 - a * x2;
            c = "y=" + a + "x+" + b;
            }
            else if (x1 == x2)
            {
                c = "x=" + x1;
            }
            else
            {
                c = "y=" + y1;
            }
            return c;
        }

        static public int[] FindResultOfDelenieAndOstatok(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("you cannot divide by zero!");
            }
            int[] c = new int[] { a / b, a % b };
            return c;
        }
    }

}