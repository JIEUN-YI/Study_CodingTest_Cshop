namespace Study_CodingTest._250323
{
    public class CodingTest_250323
    {
        /// <summary>
        /// 제목 : 양꼬치
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120830
        /// 문제 : 머쓱이네 양꼬치 가게는 10인분을 먹으면 음료수 하나를 서비스로 줍니다. 양꼬치는 1인분에 12,000원, 음료수는 2,000원입니다. 
        ///        정수 n과 k가 매개변수로 주어졌을 때, 양꼬치 n인분과 음료수 k개를 먹었다면 총얼마를 지불해야 하는지 
        ///        return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 10, 3 ] => [ 124,000 ] / [ 64, 6 ] => [ 768,000 ]
        /// </summary>
        /// 
        public int HowMuch(int n, int k)
        {
            k -= n / 10; // 구매한 음료수
            return 12000 * n + 2000 * k;
        }

        /// <summary>
        /// 제목 : 편지
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120898
        /// 문제 : 머쓱이는 할머니께 생신 축하 편지를 쓰려고 합니다. 할머니가 보시기 편하도록 글자 한 자 한 자를 가로 2cm 크기로 적으려고 하며, 
        ///        편지를 가로로만 적을 때, 축하 문구 message를 적기 위해 필요한 편지지의 최소 가로길이를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : [ "happy birthday!" ] => [ 30 ] / [ "I love you~" ] => [ 22 ]
        /// </summary>
        /// 
        public int LetterLengteh(string message)
        {
            char[] chars = message.ToCharArray();
            int result = chars.Length * 2;

            return result;
        }

        /// <summary>
        /// 제목 : 세균 증식
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120910
        /// 문제 : 어떤 세균은 1시간에 두배만큼 증식한다고 합니다. 
        ///        처음 세균의 마리수 n과 경과한 시간 t가 매개변수로 주어질 때 t시간 후 세균의 수를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 2, 10 ] => [ 2048 ] / [ 7, 15 ] => [ 229,376 ]
        /// </summary>
        /// 
        public int VirusIncrease(int n, int t)
        {
            for (int i = 0; i < t; i++)
            {
                n *= 2;
            }
            return n;
        }

        /// <summary>
        /// 제목 : 짝수 홀수 개수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120824
        /// 문제 : 정수가 담긴 리스트 num_list가 주어질 때, num_list의 원소 중 짝수와 홀수의 개수를 담은 배열을 return 하도록 
        ///        solution 함수를 완성해보세요.
        /// 예시 : [ { 1, 2, 3, 4, 5 } ] => [ { 2, 3 } ] / [ { 1, 3, 5, 7 } ] => [ { 0, 4 } ]
        /// </summary>
        /// 
        public int[] EvenOddCount(int[] num_list)
        {
            int even = 0; // 짝수
            int odd = 0; // 홀수
            foreach (int n in num_list)
            {
                if (n % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            int[] result = new int[2];
            result[0] = even;
            result[1] = odd;

            return result;
        }

        /// <summary>
        /// 제목 : 문자열 뒤집기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120822
        /// 문제 : 문자열 my_string이 매개변수로 주어집니다. my_string을 거꾸로 뒤집은 문자열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ "jaron" ] => [ "noraj" ] / [ "bread" ] => [ "daerb" ]
        /// </summary>
        /// 
        public string ReverseString(string my_string)
        {
            char[] my_char = my_string.ToCharArray(); // 원래의 문자열
            char[] reverseChar = new char[my_char.Length];
            for (int i = 0, j = my_char.Length - 1; i < my_char.Length; i++, j--)
            {
                reverseChar[i] = my_char[j];
            }
            string result = new string(reverseChar);
            return result;
        }

        /// <summary>
        /// 제목 : 최댓값 만들기 (2) - CodingTest_20250126.cs
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120862
        /// 문제 : 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2, -3, 4, -5 ] => [ 15 ] / [ 0, -31, 24, 10, 1, 9 ] => [ 240 ] / [ 10, 20, 30, 5, 5, 20, 5 ] => [ 600 ]
        /// 풀이 : 배열을 정열 후 앞에 두 수 와 뒤의 두 수를 곱하여 둘 중 큰 값을 출력
        ///        => 앞의 두 수가 모두 - 이면 양수가 되기 때문
        /// </summary>
        public int MaxNumMaker2(int[] numbers)
        {
            Array.Sort(numbers); // 배열을 재정렬
            int frontNum = numbers[0] * numbers[1];
            int backNum = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];

            return Math.Max(frontNum, backNum);
        }

        /// <summary>
        /// 제목 : 문자열 정렬하기 (2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120911
        /// 문제 : 영어 대소문자로 이루어진 문자열 my_string이 매개변수로 주어질 때, 
        ///        my_string을 모두 소문자로 바꾸고 알파벳 순서대로 정렬한 문자열을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ "Bcad" ] => [ "abcd" ] / [ "heLLo" ] => [ "ehllo" ] / [ "Python" ] => [ "hnopty" ]
        /// </summary>
        /// 
        public string ChangeString(string my_string)
        {
            string LowerStr = my_string.ToLower(); // 소문자로 문자열 변환 => ToUpper() : 대문자로 변환
            char[] chars = LowerStr.ToCharArray();
            Array.Sort(chars);
            string result = new string(chars);

            return result;
        }

        /// <summary>
        /// 제목 : 피자 나눠 먹기 (2) - CodingTest_20250126.cs
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120815
        /// 문제 : 머쓱이네 피자가게는 피자를 여섯 조각으로 잘라 줍니다. 피자를 나눠먹을 사람의 수 n이 매개변수로 주어질 때, 
        ///        n명이 주문한 피자를 남기지 않고 모두 같은 수의 피자 조각을 먹어야 한다면 최소 몇 판을 시켜야 하는지를
        ///        return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 6 ] => [ 1 ] / [ 10 ] => [ 5 ] / [ 4 ] => [ 2 ]
        /// </summary>
        /// 최종 : 사람의 수 * 피자 조각의 수가 가장 작은 6의 배수가 될 때의 피자의 개수
        public int SharePizza(int n)
        {
            int piece = 0;
            for (int i = 1; ; i++)
            {
                if ((n * i) % 6 == 0)
                {
                    piece = i;
                    break;
                }
            }
            int pizza = (n * piece) / 6;

            return pizza;
        }

        /// <summary>
        /// 제목 : 한 번만 등장한 문자
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120896
        /// 문제 : 문자열 s가 매개변수로 주어집니다. s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 
        ///        문자열을 return 하도록 solution 함수를 완성해보세요. 한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.
        /// 예시 : [ "abcabcadc" ]=>[ "d" ] / [ "abdc" ]=>[ "abcd" ] / [ "hello" ]=>[ "eho" ]
        /// </summary>
        /// 프로그래머스 에러 : Solution0.cs(32,46): error CS1525: Unexpected symbol `(', expecting `)', `,', or `identifier'
        public string OneStirng(string s)
        {
            // 문자를 문자열 배열로 만들기
            char[] spells = s.ToCharArray();
            Array.Sort(spells); // 오름차순으로 정렬
            List<char> answer = new List<char>(spells.Length);
            for (int i = 0; i < spells.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < spells.Length; j++)
                {

                    if (spells[i] == spells[j])
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (count == 1)
                {
                    answer.Add(spells[i]);
                }
            }
            string result = new string(answer.ToArray());
            return result;
        }

        /// <summary>
        /// 제목 : 문자열 계산하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120902
        /// 문제 : my_string은 "3 + 5"처럼 문자열로 된 수식입니다. 
        ///        문자열 my_string이 매개변수로 주어질 때, 수식을 계산한 값을 return 하는 solution 함수를 완성해주세요.
        /// 예시 : [ "3 + 4" ] => [ 7 ]
        /// </summary>
        /// 제대로 작동하지만 프로그래머스 에러 발생
        /// error CS0234: The type or namespace name `Data' does not exist in the namespace `System'. Are you missing `System.Data' assembly reference?
        /// using 문 추가하여도 에러 발생
        public static int CalculateNum(string my_string)
        {
            string[] newStr = my_string.Split(" ").ToArray();

            int result = int.Parse(newStr[0]);

            for (int i = 1; i < newStr.Length; i += 2)
            {
                int num = int.Parse(newStr[i + 1]);
                if (newStr[i] == "+")
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }

            return result;
        }

        /// <summary>
        /// 제목 : 최빈값 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120812
        /// 문제 : 최빈값은 주어진 값 중에서 가장 자주 나오는 값을 의미합니다. 
        ///        정수 배열 array가 매개변수로 주어질 때, 최빈값을 return 하도록 solution 함수를 완성해보세요. 
        ///        최빈값이 여러 개면 -1을 return 합니다.
        /// 예시 : [ { 1, 2, 3, 3, 3, 4 } ] => [ 3 ] / [ { 1, 1, 2, 2 } ] => [ -1 ] / [ { 1 } ] => [ 1 ]
        /// </summary>
        /// 
        public int MaxFrequency(int[] array)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                int countNum = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (!dic.ContainsKey(array[i])) // 탐색해서 저장하지 않은 값만
                    {
                        if (array[i] == array[j])
                        {
                            countNum++;
                        }
                        else continue;
                    }
                    else break;
                }
                if (!dic.ContainsKey(array[i])) // 동일한 키가 있는지 확인
                {
                    dic.Add(array[i], countNum);
                }
            }
            int maxNum = 0;
            int key = 0;
            int count = 0;
            foreach (int i in dic.Values) // 전체 값을 돌면서 가장 큰 값 찾기
            {
                maxNum = Math.Max(maxNum, i);
            }
            foreach (int i in dic.Keys) // 전체 키를 돌면서
            {
                dic.TryGetValue(i, out int value);
                if (value == maxNum) // 그 키의 값이 최대값인지 확인
                {
                    key = i;
                    count++; // 최대값의 개수 찾기
                }
            }
            if (count > 1) // 최빈값이 하나 이상이면
            {
                return -1;
            }
            return key; // 최빈값이 하나 이면
        }

        /// <summary>
        /// 제목 : 안전지대
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120866
        /// 문제 : 다음 그림과 같이 지뢰가 있는 지역과 지뢰에 인접한 위, 아래, 좌, 우 대각선 칸을 모두 위험지역으로 분류합니다.
        ///        지뢰는 2차원 배열 board에 1로 표시되어 있고 board에는 지뢰가 매설 된 지역 1과, 지뢰가 없는 지역 0만 존재합니다.
        ///        지뢰가 매설된 지역의 지도 board가 매개변수로 주어질 때, 안전한 지역의 칸 수를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 } ] => [ 16 ] / 
        ///        [ { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 0, 0, 0, 0 } ] => [ 13 ] / 
        ///        [ { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, 
        ///          { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } ] => [ 0 ]
        /// </summary>
        /// 
        public int SafeZone(int[,] board)
        {
            bool[,] safeArea = new bool[board.GetLength(0), board.GetLength(1)];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++) // 주어진 2차원 배열을 돌면서
                {
                    if (board[i, j] == 1) // 지뢰가 있는 1을 찾은 경우
                    {
                        // 주변 9칸을 true로 safeArea 배열을 변경함
                        // 범위 설정이 중요
                        // 각 행열은 0부터 시작해야하며 -1값이 0보다 작은 경우 시작값은 0이고, 배열의 사이즈를 넘어가지 않고, +1값까지 변동
                        for (int row = Math.Max(0, i - 1); row < safeArea.GetLength(0) && row <= i + 1; row++)
                        {
                            for (int col = Math.Max(0, j - 1); col < safeArea.GetLength(1) && col <= j + 1; col++)
                            {
                                safeArea[row, col] = true;
                            }
                        }
                    }
                }
            }
            int count = 0;
            foreach (bool i in safeArea)
            {
                if (i == false)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// 제목 : 겹치는 선분의 길이
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120876
        /// 문제 : 선분 3개가 평행하게 놓여 있습니다. 
        ///        세 선분의 시작과 끝 좌표가 [[start, end], [start, end], [start, end]] 형태로 들어있는 2차원 배열 lines가 매개변수로 주어질 때, 
        ///        두 개 이상의 선분이 겹치는 부분의 길이를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ { 0, 1 }, { 2, 5 }, { 3, 9 } ] => [ 2 ] / [ { -1, 1 }, { 1, 3 }, { 3, 9 } ] => [ 0 ] / 
        ///        [ { 0, 5 }, { 3, 9 }, { 1, 10 } ] => [ 8 ]
        /// </summary>
        /// 
        public int OverlapLine(int[,] lines)
        {
            // 2차원 배열의 앞자리와 뒷자리만 저장하는 리스트
            List<int> front = new List<int>();
            List<int> back = new List<int>();
            // 각 최종 결과를 나타내는 변수
            int resultF = 0;
            int resultB = 0;

            // 모든 비교의 수를 비교하여 실제 겹치는 범위를 찾아 저장
            if (Math.Max(lines[0, 0], lines[1, 0]) < Math.Min(lines[0, 1], lines[1, 1]))
            {
                front.Add(Math.Max(lines[0, 0], lines[1, 0]));
                back.Add(Math.Min(lines[0, 1], lines[1, 1]));
            }
            if (Math.Max(lines[0, 0], lines[2, 0]) < Math.Min(lines[0, 1], lines[2, 1]))
            {
                front.Add(Math.Max(lines[0, 0], lines[2, 0]));
                back.Add(Math.Min(lines[0, 1], lines[2, 1]));
            }
            if (Math.Max(lines[1, 0], lines[2, 0]) < Math.Min(lines[1, 1], lines[2, 1]))
            {
                front.Add(Math.Max(lines[1, 0], lines[2, 0]));
                back.Add(Math.Min(lines[1, 1], lines[2, 1]));
            }
            int answer = 0;
            // 리스트의 용량이 3이면
            if (front.Count == 3)
            {
                // 앞자리의 최소값과 뒷자리의 최대값의 차이가 겹치는 구간의 길이
                resultF = front[0];
                resultB = back[0];
                for(int i = 0; i < front.Count; i++)
                {
                    resultF = Math.Min(resultF, front[i]);
                    resultB = Math.Max(resultB, back[i]);
                }
                answer = resultB - resultF;
                return answer;
            }
            else // 리스트의 용량이 2이하인 경우에는 구간의 차를 합한 값이 겹치는 구간의 길이
            {
                for(int i = 0; i < front.Count; i++)
                {
                    answer += back[i] - front[i];
                }
                return answer;
            }
        }

        /// <summary>
        /// 제목 : 평행
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120875
        /// 문제 : 점 네 개의 좌표를 담은 이차원 배열  dots가 다음과 같이 매개변수로 주어집니다.
        ///        [[x1, y1], [x2, y2], [x3, y3], [x4, y4]] 주어진 네 개의 점을 두 개씩 이었을 때, 
        ///        두 직선이 평행이 되는 경우가 있으면 1을 없으면 0을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ { 1, 4 }, { 9, 2 }, { 3, 8 }, { 11, 6 } ] => [ 1 ] / 
        ///        [ { 3, 5 }, { 4, 1 }, { 2, 4 }, { 5, 10 } ] => [ 0 ]
        /// </summary>
        /// 
        public static void Parallel(int[,] dots)
        {
            List<int> lean = new List<int>(); // 선분의 기울기를 저장하는 리스트
            int xNum = 0;
            int yNum = 0;
            for(int i = 0;i + 1 < dots.GetLength(0); i++)
            {
                if (dots[i, 0] > dots[i + 1, 0])
                {

                }
                else if (dots[i, 0] < dots[i + 1, 1])
                {

                }
                else
                {

                }
            }
        }
        /// <summary>
        /// 제목 : 옹알이 (1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120956
        /// 문제 : 
        /// 예시 : [  ] => [  ]
        /// </summary>
        /// 스터디 : replace 활용해 제거


    }
}

