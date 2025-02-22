using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_CodingTest
{
    public class CodingTest_20240817
    {
        /// <summary>
        /// 제목 : 나머지 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120810
        /// 문제 : 정수 num1, num2가 매개변수로 주어질 때, 
        ///         num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 3, 2 ) => 1, ( 10, 5 ) => 0
        /// </summary>
        public int DivideRest(int num1, int num2)
        {
            return num1 % num2;
        }

        /// <summary>
        /// 제목 : 두 수의 곱
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120804
        /// 문제 : 정수 num1, num2가 매개변수 주어집니다. 
        ///        num1과 num2를 곱한 값을 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 3, 4 ) => 12, ( 27, 19 ) => 513
        /// </summary>
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// 제목 : 숫자 비교하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120807
        /// 문제 : 정수 num1과 num2가 매개변수로 주어집니다. 
        ///        두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 2, 3 ) => -1, ( 11, 11 ) => 1
        /// </summary>
        public int CompareNum(int num1, int num2)
        {
            int result = -1;
            if(num1 == num2)
            {
                result = 1;
            }
            else
            {
                result = -1;
            }
            return result;
        }

        /// <summary>
        /// 제목 : 나이 출력
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120820
        /// 문제 : 머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다. 
        ///        2022년 기준 선생님의 나이 age가 주어질 때, 선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요
        /// 예시 : ( 40 ) => 1983, ( 23 ) => 2000
        /// </summary>
        public int FindYear(int age)
        {
            int year = 2022 - age + 1;

            return year;
        }

        /// <summary>
        /// 제목 : 두 수의 차
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120803
        /// 문제 : 정수 num1과 num2가 주어질 때, num1에서 num2를 뺀 값을 return하도록 soltuion 함수를 완성해주세요.
        /// 예시 : ( 2, 3 ) => -1, ( 100, 2 ) => 98
        /// </summary>
        public int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// 제목 : 몫 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120805
        /// 문제 : 정수 num1, num2가 매개변수로 주어질 때, 
        ///        num1을 num2로 나눈 몫을 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 10, 5 ) => 2, ( 7, 2 ) => 3
        /// </summary>
        public int DivideShare(int num1, int num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// 제목 : 두 수의 나눗셈
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120806
        /// 문제 : 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 
        ///        정수 부분을 return 하도록 soltuion 함수를 완성해주세요.
        /// 예시 : ( 3, 2 ) => 1500, ( 7, 3 ) => 2333, ( 1, 16 ) => 62
        /// </summary>
        public int DivideInt(int num1, int num2)
        {
            /*double result;
            result = (double)num1 / (double)num2 * 1000;

            return (int)result;*/
            int result;
            result = num1 * 1000 / num2;

            return result;
        }

        /// <summary>
        /// 제목 : 배열의 평균값
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120817
        /// 문제 : 정수 배열 numbers가 매개변수로 주어집니다. 
        ///        numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ] => 5.5, [ 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 ] => 94.0
        /// </summary>
        public double ArrayAverage(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double result = sum / array.Length;
            return result;
        }

        /// <summary>
        /// 제목 : 각도기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120829
        /// 문제 : 각에서 0도 초과 90도 미만은 예각, 90도는 직각, 90도 초과 180도 미만은 둔각 180도는 평각으로 분류합니다.
        ///        각 angle이 매개변수로 주어질 때 예각일 때 1, 직각일 때 2, 둔각일 때 3, 평각일 때 4를 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : ( 70 ) => 1, ( 91 ) => 3, ( 180 ) => 4
        /// </summary>
        public int Protractor(int num)
        {
            int result = 0;
            if (0 < num && num < 90)
            {
                result = 1;
            }
            else if (num == 90)
            {
                result = 2;
            }
            else if (90 < num && num < 180)
            {
                result = 3;
            }
            else if (num == 180)
            {
                result = 4;
            }
            return result;
        }

        /// <summary>
        /// 제목 : 짝수의 합
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120831
        /// 문제 : 정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
        /// 예시 : ( 10 ) => 30, ( 4 ) => 6
        /// </summary>
        public int PlusEvenNum(int num)
        {
            int sum = 0;
            for(int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else continue;
            }
            return sum;
        }
    }
}
