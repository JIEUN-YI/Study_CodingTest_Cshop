using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace Study_CodingTest._20241110Study
{
    public class CodingTest_20241110
    {
        /// <summary>
        /// 제목 : 진료 순서 정하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120835
        /// 문제 : 외과의사 머쓱이는 응급실에 온 환자의 응급도를 기준으로 진료 순서를 정하려고 합니다. 
        ///        정수 배열 emergency가 매개변수로 주어질 때 응급도가 높은 순서대로 진료 순서를 정한 배열을
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : [3, 76, 24] => [3, 1, 2] / [1, 2, 3, 4, 5, 6, 7] => [7, 6, 5, 4, 3, 2, 1] / [30, 10, 23, 6, 100] => [2, 4, 3, 5, 1]
        /// </summary>

        public static int[] OrderNum(int[] emergency)
        {
            int[] result = new int[emergency.Length];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < emergency.Length; i++)
            {
                map.Add(i, emergency[i]);
            }
            // 값으로 정렬 후 키에 알맞은 인덱스에 i값을 저장하여 우선순위를 표현
            map = map.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int count = 1;
            foreach (int i in map.Keys)
            {
                result[i] = count;
                count++;
            }

            return result;

            /*
            int[] result = new int[emergency.Length];
            for(int i = 0; i < emergency.Length; i++)
            {
                int control = 1;
                for (int j = 0; j < emergency.Length; j++ )
                {
                    if(emergency[i] < emergency[j])
                    {
                        control++;
                    }
                    else
                    {
                        control--;
                    }
                }
                if(control <= 0)
                {
                    control = -control;
                }
                result[i] = control;
            }
            return result;
            */
        }

        /// <summary>
        /// 제목 : 팩토리얼
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120848
        /// 문제 : i팩토리얼 (i!)은 1부터 i까지 정수의 곱을 의미합니다. 
        ///        예를들어 5! = 5 * 4 * 3 * 2 * 1 = 120 입니다. 정수 n이 주어질 때 다음 조건을 만족하는 
        ///        가장 큰 정수 i를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 3628800 ) => ( 10 ) / ( 7 ) => ( 3 )
        /// </summary>

        public static int Factorial(int n)
        {
            int num = 1;
            for (int i = 1; i < 11; i++)
            {
                num *= i;

                if (num > n) return i - 1;
            }
            return 10;
        }

        /// <summary>
        /// 제목 : 숨어있는 숫자의 덧셈(2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120864
        /// 문제 : 문자열 my_string이 매개변수로 주어집니다. my_string은 소문자, 대문자, 자연수로만 
        ///        구성되어있습니다. my_string안의 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( "aAb1B2cC34oOp" ) => ( 37 ) / ( "1a2b3c4d123Z" ) => ( 133 )
        /// </summary>

        public static int NumAdd(string my_string)
        {
            string[] arr = Regex.Split(my_string, @"\D+"); // 숫자를 기준으로 배열을 분할하고
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "") // 값이 비어있지 않은 경우
                {
                    result[i] = int.Parse(arr[i]); // int형으로 형변환
                }
            }
            int num = 0;
            for (int i = 0; i < result.Length; i++)
            {
                num += result[i];
            }
            return num;
            /*string tempStr = Regex.Replace(my_string, @"\D", "");
            int result = int.Parse(tempStr);
            Console.WriteLine(result);*/
        }

        /// <summary>
        /// 제목 : A로 B 만들기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120886
        /// 문제 : 문자열 before와 after가 매개변수로 주어질 때, before의 순서를 바꾸어 
        ///         after를 만들 수 있으면 1을, 만들 수 없으면 0을 return 하도록 solution 함수를 
        ///         완성해보세요.
        /// 예시 : ( "olleh", "hello" ) => ( 1 ) / ( "allpe", "apple" ) => ( 0 )
        /// </summary>

        public static int ChangeAB(string before, string after)
        {
            // 문자열을 char형 배열로 전환
            char[] reBefore = before.ToCharArray(); 
            char[] reAfter = after.ToCharArray();

            // 문자를 정렬
            Array.Sort(reBefore);
            Array.Sort(reAfter);

            for(int i = 0;i < reBefore.Length;i++)
            {
                if (reBefore[i].Equals(reAfter[i])) // 문자열을 비교할 때 사용하는 함수 - 주의할 것
                {
                    continue;
                }
                else
                {
                    return 0;
                }
            }
            return 1;

            /*
            for (int i = 0; i < before.Length; i++)
            {
                if (after.Contains(before[i]))
                {
                    continue;
                }
                else if (!after.Contains(before[i]))
                {
                    return 0;
                }
            }
            return 1;
            */
        }

        /// <summary>
        /// 제목 : 가까운 수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120890
        /// 문제 : 정수 배열 array와 정수 n이 매개변수로 주어질 때, array에 들어있는 정수 중 
        ///        n과 가장 가까운 수를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( [ 3, 10, 28 ], 20 ) => ( 28 ) / ( [ 10, 11, 12 ], 13 ) => ( 12 )
        /// </summary>

        public static int CloserNum(int[] array, int n)
        {
            int answer = 0;
            Array.Sort(array); // 정렬 해서 작은 값을 먼저 검사하도록 설정
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (n - array[i] < 0)
                {
                    result[i] = array[i] - n;
                }
                else
                {
                    result[i] = n - array[i];
                }
            }
            int j = result.Min();

            // 같은 차이값을 가지는 경우 작은 값을 반환해야함
            for (int i = 0; i < result.Length; i++)
            {
                if (j == result[i])
                {
                    answer = array[i];
                    return answer;
                }
            }
            return answer;
        }

    }
}
