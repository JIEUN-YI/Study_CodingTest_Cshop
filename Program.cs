using Study_CodingTest._250309;
using System;

namespace Study_CodingTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] lines1 =
            {
                { 0, 1 }, { 2, 5 }, { 3, 9 }
            };
            int[,] lines2 =
            {
                { -1, 1 }, { 1, 3 }, { 3, 9 }
            };
            int[,] lines3 =
            {
                { 0, 5 }, { 3, 9 }, { 1, 10 }
            };
            CodingTest_250309.OverlapLine(lines1);
            CodingTest_250309.OverlapLine(lines2);
            CodingTest_250309.OverlapLine(lines3);
        }
    }
}
