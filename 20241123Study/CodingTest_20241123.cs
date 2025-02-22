using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace Study_CodingTest._20241123Study
{
    public class CodingTest_20241123
    {
        /// <summary>
        /// 제목 : 가위 바위 보
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120839
        /// 문제 : 가위는 2 바위는 0 보는 5로 표현합니다. 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때, 
        ///        rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return하도록 solution 함수를 완성해보세요.
        /// 예시 :  [2] => [0] / [205] => [052]
        /// </summary>
        public string RSP(string rsp)
        {
            // string문자열을 하나씩 적용하는 char 배열로 분해
            char[] answer = new char[rsp.Length];

            // 모든 배열을 돌면서
            for (int i = 0; i < rsp.Length; i++)
            {
                // 알맞은 값을 char 배열에 저장
                switch (rsp[i])
                {
                    case '0':
                        answer[i] = '5';
                        break;
                    case '2':
                        answer[i] = '0';
                        break;
                    case '5':
                        answer[i] = '2';
                        break;
                }
            }
            // char[]을 문자열인 string으로 변경
            string result = new string(answer);
            return result;
        }

        /// <summary>
        /// 제목 : 숨어있는 숫자의 덧셈 (1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120851
        /// 문제 : 문자열 my_string이 매개변수로 주어집니다. my_string안의 모든 자연수들의 합을 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : ["aAb1B2cC34oOp"] => [10] / ["1a2b3c4d123"] => [16]
        /// </summary>
        public int HidingNumAdd(string my_string)
        {
            // Regex.Replace(기존 문자열, 정규표현식, 대체할 문자)
            //               기존 문자열에서 0-9사이의 숫자가 아닌 문자를 대체하기 
            string arr = Regex.Replace(my_string, @"[^0-9]", "");
            char[] answer = arr.ToCharArray();
            int result = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                // char.GetNumericValue = double 형식으로 char에 있는 값을 형변환
                // (int)char.GetNumericValue(변환할 char형)으로 int형으로 묵시적 형변환
                result += (int)char.GetNumericValue(answer[i]);

            }
            return result;
        }

        /// <summary>
        /// 제목 : 점의 위치 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120841
        /// 문제 : 사분면은 한 평면을 x축과 y축을 기준으로 나눈 네 부분입니다. 사분면은 아래와 같이 1부터 4까지 번호를매깁니다.
        ///        x 좌표와 y 좌표가 모두 양수이면 제1사분면에 속합니다.
        ///        x 좌표가 음수, y 좌표가 양수이면 제2사분면에 속합니다.
        ///        x 좌표와 y 좌표가 모두 음수이면 제3사분면에 속합니다.
        ///        x 좌표가 양수, y 좌표가 음수이면 제4사분면에 속합니다.
        ///        x 좌표 (x, y)를 차례대로 담은 정수 배열 dot이 매개변수로 주어집니다. 
        ///        좌표 dot이 사분면 중 어디에 속하는지 1, 2, 3, 4 중 하나를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : [2, 4] => [1] / [-7, 9] => [2]
        /// </summary>
        public int FindDotPos(int[] dot)
        {
            if (dot[0] > 0 && dot[1] > 0)
            {
                return 1;
            }
            else if (dot[0] > 0 && dot[1] < 0)
            {
                return 4;
            }
            else if (dot[0] < 0 && dot[1] < 0)
            {
                return 3;
            }
            else if (dot[0] < 0 && dot[1] > 0)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 제목 : 특정 문자 제거하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120826
        /// 문제 : 문자열 my_string과 문자 letter이 매개변수로 주어집니다. 
        ///        my_string에서 letter를 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ["abcdef", "f"] => ["abcde"] / ["BCBdbe", "B"] => ["Cdbe"]
        /// </summary>
        public string DeleteChar(string my_string, string letter)
        {
            string result = my_string.Replace(letter, "");
            return result;
        }

        /// <summary>
        /// 제목 : 약수 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120897
        /// 문제 : 정수 n이 매개변수로 주어질 때, n의 약수를 오름차순으로 담은 배열을 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : [24] => [1, 2, 3, 4, 6, 8, 12, 24] / [29] => [1, 29]
        /// </summary>
        public static int[] MeasureNum(int num) // 테스트 케이스 2번 = num이 1일 때
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= num; i++) // 1일때도 for문이 돌아가도록 i<=num으로 설정 필요 (수정전 : i<num)
            {
                if (num % i == 0)
                {
                    if (!list.Contains(i))
                    {
                        list.Add(i);
                    }
                    if (!list.Contains(num / i))
                    {
                        list.Add(num / i);
                    }
                }
                else if (num % i != 0)
                {
                    continue;
                }
            }
            int[] result = list.ToArray();
            Array.Sort(result);
            return result;
        }
    }
}
