using System.Text.RegularExpressions;

namespace Study_CodingTest._20250209Study
{
    public class CodingTest_20250209
    {
        /// <summary>
        /// 제목 : 문자열 정렬하기 (1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120850
        /// 문제 : 문자열 my_string이 매개변수로 주어질 때, my_string 안에 있는 숫자만 골라 
        ///        오름차순 정렬한 리스트를 return 하도록 solution 함수를 작성해보세요.
        /// 예시 : [ hi12392 ] => [ 1, 2, 2, 3, 9 ] / [ p2o4i8gj2 ] => [ 2, 2, 4, 8 ] / [ abcde0 ] => [ 0 ]
        /// </summary>
        public int[] StringArray(string my_string)
        {
            // 참고 사이트 : https://dallcom-forever2620.tistory.com/45
            // Regex 클래스를 사용
            //                  Replace(대체할 문자열, 문자열 중 일반문자를 지칭, 공백("")으로 대체
            string newString = Regex.Replace(my_string, @"\D", "");
            char[] strings = newString.ToCharArray();
            int[] answer = new int[strings.Length];
            // 참고 사이트 : https://ardmos.tistory.com/entry/Unity-C-String-to-int-Char-to-int
            // char => int 형변환
            for (int i = 0; i < strings.Length; i++)
            {
                string change = strings[i].ToString();
                answer[i] = int.Parse(change);
            }
            Array.Sort(answer);
            return answer;
        }

        /// <summary>
        /// 제목 : 문자 반복 출력하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120825
        /// 문제 : 문자열 my_string과 정수 n이 매개변수로 주어질 때, my_string에 들어있는 각 문자를 
        ///        n만큼 반복한 문자열을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ hello, 3 ] => [ hhheeellllllooo ]
        /// </summary>
        public string StringRepeat(string my_string, int n)
        {
            char[] charAnswer = new char[my_string.Length * n];
            char[] chars = my_string.ToCharArray();
            // i는 chars 배열에 사용할 인덱스 => +1
            // k는 charAnswer 배열에 사용할 인덱스 => +n
            for (int i = 0, k = 0; i < chars.Length; i++, k += n)
            {
                for (int j = 0; j < n; j++)
                {
                    charAnswer[k + j] = chars[i];
                }
            }
            string answer = new string(charAnswer);
            return answer;
        }

        /// <summary>
        /// 제목 : 최댓값 만들기 (1) 
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120847
        /// 문제 : 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2, 3, 4, 5 ] => [ 20 ] / [ 0, 31, 24, 10, 1, 9 ] => [ 744 ]
        /// </summary>
        public int MaxNumMaker(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers); // 내림차순 정렬
            return numbers[0] * numbers[1];
        }

        /// <summary>
        /// 제목 : 최댓값 만들기 (2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120862
        /// 문제 : 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2, -3, 4, -5 ] => [ 15 ] / [ 0, -31, 24, 10, 1, 9 ] => [ 240 ] / [ 10, 20, 30, 5, 5, 20, 5 ] => [ 600 ]
        /// 풀이 : 배열을 정열 후 앞에 두 수 와 뒤의 두 수를 곱하여 둘 중 큰 값을 출력
        ///        => 앞의 두 수가 모두 - 이면 양수가 되기 때문
        /// </summary>
        public static void MaxNumMaker2(int[] numbers)
        {
            Dictionary<int, int> absolute = new Dictionary<int, int>();
            //int[] absolute = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    // 절대값으로 비교하기 위해 변환
                    int value = numbers[i] * -1;
                    absolute.Add(i, value);
                }
                else
                {
                    int value = numbers[i];
                    absolute.Add(i, value);
                }
            }
        }

        /// <summary>
        /// 제목 : 모음 제거
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120849
        /// 문제 : 영어에선 a, e, i, o, u 다섯 가지 알파벳을 모음으로 분류합니다. 
        ///        문자열 my_string이 매개변수로 주어질 때 모음을 제거한 문자열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ bus ] => [ bs ] / [ nice to meet you ] => [ nc t mt y ]
        /// </summary>
        public string DeleteVowel(string my_string)
        {
            // 더 효율적인 방법이 있지 않을까...?
            string answer;
            answer = Regex.Replace(my_string, "A", "");
            answer = Regex.Replace(answer, "a", "");
            answer = Regex.Replace(answer, "E", "");
            answer = Regex.Replace(answer, "e", "");
            answer = Regex.Replace(answer, "I", "");
            answer = Regex.Replace(answer, "i", "");
            answer = Regex.Replace(answer, "O", "");
            answer = Regex.Replace(answer, "o", "");
            answer = Regex.Replace(answer, "U", "");
            answer = Regex.Replace(answer, "u", "");
            return answer;
        }

        /// <summary>
        /// 제목 : 피자 나눠 먹기 (2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120815
        /// 문제 : 머쓱이네 피자가게는 피자를 여섯 조각으로 잘라 줍니다. 피자를 나눠먹을 사람의 수 n이 매개변수로 주어질 때, 
        ///        n명이 주문한 피자를 남기지 않고 모두 같은 수의 피자 조각을 먹어야 한다면 최소 몇 판을 시켜야 하는지를
        ///        return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 6 ] => [ 1 ] / [ 10 ] => [ 5 ] / [ 4 ] => [ 2 ]
        /// 풀이 3으로 나누어 나머지가 0인 경우 몫을 저장하고 몫을 2로 나누어 나머지가 0이면 그 결과를 리턴
        /// </summary>
        /// 여기서는 잘 되는데, 프로그래머스에서는 안넘어가짐
        public static int SharePizza(int n)
        {
            // 두 수(6과 n)의 최소 공배수를 6에 곱해서 만드는 수
            int answer = 0;
            int gcd = 0;
            int lcd = 0;

            if (n >= 6)
            {
                // 최소공배수 = 두수의 곱 / 최대공약수
                gcd = GetGcd(n, 6);
                lcd = (n * 6) / gcd;
            }
            else
            {
                gcd = GetGcd(6, n);
                lcd = (n * 6) / gcd;
            }
            answer = lcd / 6;
            return answer;
        }
        public static int GetGcd(int a, int b)// 최대공약수 구하기
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return GetGcd(a, a % b);
            }
        }

        /// <summary>
        /// 제목 : 배열 회전시키기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120844
        /// 문제 : 정수가 담긴 배열 numbers와 문자열 direction가 매개변수로 주어집니다. 
        ///        배열 numbers의 원소를 direction방향으로 한 칸씩 회전시킨 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ { 1, 2, 3 }, "right" ] => [ 3, 1, 2 ] / [ { 4, 455, 6, 4, -1, 45, 6 }, "left" ] => [ 455, 6, 4, -1, 45, 6, 4 ]
        /// </summary>
        public int[] RotationArray(int[] numbers, string direction)
        {
            int[] answer = new int[] { };
            switch (direction)
            {
                case "right":
                    answer = new int[numbers.Length];
                    answer[0] = numbers[numbers.Length - 1];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        answer[i] = numbers[i - 1];
                    }
                    break;
                case "left":
                    answer = new int[numbers.Length];
                    answer[numbers.Length - 1] = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        answer[i - 1] = numbers[i];
                    }
                    break;
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 369게임
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120891 
        /// 문제 : 머쓱이는 친구들과 369게임을 하고 있습니다. 369게임은 1부터 숫자를 하나씩 대며 3, 6, 9가 들어가는 숫자는 숫자 대신 
        ///        3, 6, 9의 개수만큼 박수를 치는 게임입니다. 머쓱이가 말해야하는 숫자 order가 매개변수로 주어질 때, 
        ///        머쓱이가 쳐야할 박수 횟수를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 3 ] => [ 1 ] / [ 29423 ] => [ 2 ]
        /// </summary>
        public int StartGame(int order)
        {
            int count = 0;
            while (order > 0)
            {
                int num = order % 10; // 나머지로 일의 자리 수 구하기
                order /= 10; // 몫을 order에 저장

                // num이 3, 6, 9인 경우 count 증가 
                if (num == 3 || num == 6 || num == 9)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 제목 : 숫자 찾기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120904 
        /// 문제 : 정수 num과 k가 매개변수로 주어질 때, num을 이루는 숫자 중에 k가 있으면 
        ///        num의 그 숫자가 있는 자리 수를 return하고 없으면 -1을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 29183, 1 ] => [ 3 ] / [ 232443, 4 ] => [ 4 ] / [ 123456, 7 ] => [ -1 ]
        /// </summary>
        public int FindNum(int num, int k)
        {
            int digit = 0;
            int count = 0;
            int i = 0;
            int hint = num;
            // 자리 수 구하기
            while (hint > 0)
            {
                hint /= 10;
                digit++;
            }
            // 자리수만큼 배열 생성
            int[] arr = new int[digit];
            // 배열 채우기
            while (num > 0)
            {
                int rest = num % 10;
                arr[i] = rest;
                i++;
                num /= 10;
            }
            // k와 같은 수 찾기
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                count++;
                if (arr[j] == k)
                {
                    return count;
                }
            }
            return -1;
        }

        /// <summary>
        /// 제목 : 외계행성의 나이
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120834
        /// 문제 : 우주여행을 하던 머쓱이는 엔진 고장으로 PROGRAMMERS-962 행성에 불시착하게 됐습니다. 
        ///        입국심사에서 나이를 말해야 하는데, PROGRAMMERS-962 행성에서는 나이를 알파벳으로 말하고 있습니다. 
        ///        a는 0, b는 1, c는 2, ..., j는 9입니다. 예를 들어 23살은 cd, 51살은 fb로 표현합니다. 
        ///        나이 age가 매개변수로 주어질 때 PROGRAMMER-962식 나이를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 23 ] => [ cd ] / [ 51 ] => [ fb ] / [ 100 ] => [ baa ]
        /// </summary>
        public string ChangeAge(int age)
        {
            // 후입선출의 스택을 이용
            Stack<int> stack = new Stack<int>();
            while (age > 0)
            {
                int num = age % 10;
                stack.Push(num); // 일의 자리부터 스택에 저장
                age /= 10;
            }
            char[] arr = new char[stack.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                // 'a' = 97 로 변환된 아스키코드를 이용하여 배열에 저장
                int answer = stack.Pop() + 97;
                arr[i] = (char)answer;
            }
            // string으로 변환하여 출력
            string ageStr = new string(arr);
            return ageStr;
        }

        /// <summary>
        /// 제목 : 합성 수 찾기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120846
        /// 문제 : 약수의 개수가 세 개 이상인 수를 합성수라고 합니다. 자연수 n이 매개변수로 주어질 때 
        ///        n이하의 합성수의 개수를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 10 ] => [ 5 ] / [ 15 ] => [ 8 ]
        /// </summary>
        public int compositNum(int num)
        {
            int count = 0; // 약수의 개수
            int composit = 0; // num 이하의 합성수의 개수
            // num 이하, 2 이상의 수 중에서
            for (int i = 2; i <= num; i++)
            {
                // 자기 자신보다 작은 수로 나누기
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) // 나누어지는 약수 찾기
                    {
                        count++;
                    }
                    continue;
                }
                if (count >= 2) // 약수의 개수가 본인 제외 2개 이상이면
                {
                    composit++; // 합성수
                }
                count = 0; // 약수개수초기화
            }
            return composit;
        }

        /// <summary>
        /// 제목 : 2차원으로 만들기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120842
        /// 문제 : 정수 배열 num_list와 정수 n이 매개변수로 주어집니다. num_list를 다음 설명과 같이
        ///        2차원 배열로 바꿔 return하도록 solution 함수를 완성해주세요.
        ///        num_list가[1, 2, 3, 4, 5, 6, 7, 8] 로 길이가 8이고 n이 2이므로 num_list를 2 * 4 배열로 다음과 같이 변경합니다. 
        ///        2차원으로 바꿀 때에는 num_list의 원소들을 앞에서부터 n개씩 나눠 2차원 배열로 변경합니다.
        /// 예시 : [ { 1, 2, 3, 4, 5, 6, 7, 8 }, 2 ] => [ { 1, 2 }, { 3, 4}, { 5, 6 }, { 7, 8 }]
        /// </summary>
        public int[,] MakeDimesion(int[] num_list, int n)
        {
            int count = 0;
            // 열과 행의 위치와 배열의 길이를 조심할 것
            int[,] answer = new int[num_list.Length / n, n];

            for (int row = 0; row < num_list.Length / n; row++)
            {
                for (int num = 0; num < n; num++)
                {
                    answer[row, num] = num_list[count];
                    count++;
                }
            }
            return answer;
        }
    }
}
