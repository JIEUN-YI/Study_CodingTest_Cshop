using Study_CodingTest._250323;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Study_CodingTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] dots1 = { { 1, 4 }, { 9, 2 }, { 3, 8 }, { 11, 6 } };
            int[,] dots2 = { { 3, 5 }, { 4, 1 }, { 2, 4 }, { 5, 10 } };

            CodingTest_250323.Parallel(dots1);
            CodingTest_250323.Parallel(dots2);

        }
    }
}
