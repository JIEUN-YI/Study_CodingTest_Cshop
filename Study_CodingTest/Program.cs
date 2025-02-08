using Study_CodingTest._250209;
using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Study_CodingTest
{
    public class Program 
    {
        static void Main(string[] args)
        {
            string my_str1 = "abc1Addfggg4556b";
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            // CodingTest_250209.OneStirng("hello"); // 에러발생
            // CodingTest_250209.CutStringTo(my_str1, 6);
            StackQueue_250209.RightParentheses("()()");
            StackQueue_250209.RightParentheses("(())()");
            StackQueue_250209.RightParentheses(")()(");
        }
    }
}
