namespace Study_CodingTest._250309
{
    public class CodingTest_250309
    {
        /// <summary>
        /// 제목 : 등수 매기기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120882
        /// 문제 : 영어 점수와 수학 점수의 평균 점수를 기준으로 학생들의 등수를 매기려고 합니다. 
        ///        영어 점수와 수학 점수를 담은 2차원 정수 배열 score가 주어질 때, 
        ///        영어 점수와 수학 점수의 평균을 기준으로 매긴 등수를 담은 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ [80, 70], [90, 50], [40, 70], [50, 80] ] => [ 1, 2, 4, 3 ]
        ///        / [ [80, 70], [70, 80], [30, 50], [90, 100], [100, 90], [100, 100], [10, 30] ] => [ 4, 4, 6, 2, 2, 1, 7 ]
        /// </summary>
        /// 1차시도 : 테스트 3, 6 실패 83.3점
        public int[] RankingScore(int[,] score)
        {
            // return할 등수를 담은 배열의 크기 = score의 열의 크기
            int[] rankingArr = new int[score.GetLength(0)]; // GetLength(0) = 세로 열 /(1) = 가로 행
            double[] averageArr = new double[score.GetLength(0)]; // 1차시도 이후 int => double로 형 변환
            for (int i = 0; i < score.GetLength(0); i++) // 열의 개수만큼 반복 진행

            {// 두 과목의 평균 : c#의 경우 int로 나누어져 저장되는 것을 소수점으로 표기하기 위해 명시적 형변환
                double average = (double)(score[i, 0] + score[i, 1]) / 2;
                averageArr[i] = average; // 평균값을 배열에 저장
            }
            // averageArr 배열의 모든 수를 한번씩 전부 비교
            for (int i = 0; i < averageArr.Length; i++)
            {
                int ranking = 1;
                for (int j = 0; j < averageArr.Length; j++)
                {
                    if (averageArr[i] >= averageArr[j]) // 현재 값이 비교 값보다 크거나 같으면 현재 랭킹 유지
                    {
                        continue;
                    }
                    else if (averageArr[i] < averageArr[j]) // 현재 값이 작으면 랭킹 하랑
                    {
                        ranking++;
                    }
                }
                rankingArr[i] = ranking; // 최종 랭킹 저장
            }
            return rankingArr;
        }

        /// <summary>
        /// 제목 : 저주의 숫자 3
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120871
        /// 문제 : 3x 마을 사람들은 3을 저주의 숫자라고 생각하기 때문에 3의 배수와 숫자 3을 사용하지 않습니다. 3x 마을 사람들의 숫자는 다음과 같습니다.
        ///         10진법	3x 마을에서 쓰는 숫자	10진법	3x 마을에서 쓰는 숫자
        ///           1	             1	              6	             8
        ///           2	             2	              7	             10
        ///           3	             4	              8	             11
        ///           4	             5	              9	             14
        ///           5	             7	              10	         16
        ///         정수 n이 매개변수로 주어질 때, n을 3x 마을에서 사용하는 숫자로 바꿔 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 15 ] => [ 25 ] / [ 40 ] => [ 76 ]
        /// </summary>
        /// 1차 시도 4번, 5번 실패 => threeVill이 세자리 수로 가는 경우 십의 자리 수 확인 필요
        ///     : 최적화적인 면에서 좋은 방식은 아닌 것 같지만 문자열로 숫자를 변환하여 3을 가지고 있는지 판별
        public int ThreeMultiple(int n)
        {
            int answer = 0;
            for (int i = 1, threeVill = 0; i <= n; i++) // 1부터 n까지의 수를 돌면서
            {
                string num;
                do
                {
                    threeVill++;
                    num = threeVill.ToString(); // 현재 threeVill 숫자를 문자로 변환
                }
                while (threeVill % 3 == 0 || num.Contains("3")); // threeVill이 3의 배수 또는 숫자 3을 포함하는 경우 반복
                answer = threeVill;
            }

            return answer;

        }

        /// <summary>
        /// 제목 : 유한소수 판별하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120878
        /// 문제 : 소수점 아래 숫자가 계속되지 않고 유한개인 소수를 유한소수라고 합니다. 
        ///        분수를 소수로 고칠 때 유한소수로 나타낼 수 있는 분수인지 판별하려고 합니다. 
        ///        유한소수가 되기 위한 분수의 조건은 다음과 같습니다. 기약분수로 나타내었을 때, 분모의 소인수가 2와 5만 존재해야 합니다.
        ///        두 정수 a와 b가 매개변수로 주어질 때, a/b가 유한소수이면 1을, 무한소수라면 2를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 7, 20 ] => [ 1 ] / [ 11, 22 ] => [ 1 ] / [ 12, 21 ] => [ 2 ]
        /// </summary>
        /// 
        public int FiniteNum(int a, int b)
        {
            List<int> aList = new List<int>();
            List<int> bList = new List<int>();

            // a의 약수를 aList에 저장
            for (int i = 2; i <= a; i++)
            {
                if (a % i == 0)
                {
                    a /= i;
                    aList.Add(i);
                    i = 1;
                }
                else
                    continue;
            }

            // b의 약수를 bList에 저장
            for (int i = 2; i <= b; i++)
            {
                if (b % i == 0)
                {
                    b /= i;
                    bList.Add(i);
                    i = 1;
                }
                else
                    continue;
            }
            // 약수의 배열로 변환
            int[] aArr = aList.ToArray();

            // a와 b의 공약수 여부를 확인하여
            foreach (int num in aArr)
            {
                if (bList.Contains(num)) // 공약수 인 경우 약분
                {
                    bList.Remove(num);
                }
                else
                {
                    continue;
                }
            }

            for (int i = 0; i < bList.Count; i++)
            {
                if (bList[i] == 2 || bList[i] == 5) // bList[i]가 2 또는 5인 경우
                {
                    continue;
                }
                else // bList[i]가 2 또는 5가 아닌 경우
                {
                    return 2;
                }
            }
            return 1;
        }

        /// <summary>
        /// 제목 : 문자열 밀기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120921
        /// 문제 : 문자열 "hello"에서 각 문자를 오른쪽으로 한 칸씩 밀고 마지막 문자는 맨 앞으로 이동시키면 "ohell"이 됩니다. 
        ///        이것을 문자열을 민다고 정의한다면 문자열 A와 B가 매개변수로 주어질 때, 
        ///        A를 밀어서 B가 될 수 있다면 밀어야 하는 최소 횟수를 return하고 밀어서 B가 될 수 없으면 -1을 return 하도록 
        ///        solution 함수를 완성해보세요.
        /// 예시 : [ "hello", "ohell" ] => [ 1 ] / [ "apple", "elppa" ] => [ -1 ] / [ "atat", "tata" ] => [ 1 ] / [ "abc", "abc" ] => [ 0 ]
        /// </summary>
        /// 
        public int PushStr(string A, string B)
        {
            List<char> aList = A.ToList();

            // A와 B가 그대로 동일 한 경우
            if (A.Equals(B))
            {
                Console.WriteLine(0);
                return 0;
            }
            else // 동일하지 않은 경우
            {
                // A의 길이만큼 반복
                for (int count = 0; count < aList.Count; count++)
                {
                    aList.Insert(0, aList[aList.Count - 1]); // 리스트의 맨 처음에 리스트 맨 끝 값을 저장
                    aList.RemoveAt(aList.Count - 1); // 리스트 맨 끝 값을 삭제
                    string checkStr = new string(aList.ToArray()); // string으로 제작
                    if (checkStr.Equals(B)) // checkStr과 B가 동일한 경우
                    {
                        return count + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// 제목 : 특이한 정렬
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120880
        /// 문제 : 정수 n을 기준으로 n과 가까운 수부터 정렬하려고 합니다. 이때 n으로부터의 거리가 같다면 더 큰 수를 앞에 오도록 배치합니다. 
        ///        정수가 담긴 배열 numlist와 정수 n이 주어질 때 numlist의 원소를 n으로부터 가까운 순서대로 정렬한 배열을 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : [ { 1, 2, 3, 4, 5, 6 }, 4 ] => [ { 4, 5, 3, 6, 2, 1 } ] /
        ///        [ { 10000, 20, 36, 47, 40, 6, 10, 7000 }, 30 ] => [ { 36, 40, 20, 47, 10, 6, 7000, 10000 } ]
        /// </summary>
        /// 풀이를 보고 정리함
        /// 참조한 사이트
        /// 1. https://kr98gyeongim.tistory.com/25
        /// 2. https://velog.io/@soldier1295/%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%98%EB%A8%B8%EC%8A%A4-C-Lv.0-%ED%8A%B9%EC%9D%B4%ED%95%9C-%EC%A0%95%EB%A0%AC
        public int[] UnusualArray(int[] numlist, int n)
        {
            // int형 배열 answer에 OrderBy 함수를 사용하여 특정 값에 맞게 정렬
            int[] answer = numlist.OrderBy(x => Math.Abs(n - x)).ThenByDescending(x => x).ToArray();
            // 1. x=> Math.Abs(n-x))
            //    : 각 값을 Math.Abs = 절대값을 기준으로 오름차순 정렬
            // 2. ThenByDescending(x => x)
            //    : 이미 정렬한 값을 Descending = 내림차순 으로 정렬
            // 3. ToArray();
            //    : 정리한 값을 배열로 전환
            return answer;
        }
        /// <summary>
        /// 제목 : 다항식 더하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120863
        /// 문제 : 한 개 이상의 항의 합으로 이루어진 식을 다항식이라고 합니다. 
        ///        다항식을 계산할 때는 동류항끼리 계산해 정리합니다. 
        ///        덧셈으로 이루어진 다항식 polynomial이 매개변수로 주어질 때, 동류항끼리 더한 결괏값을 
        ///        문자열로 return 하도록 solution 함수를 완성해보세요. 같은 식이라면 가장 짧은 수식을 return 합니다.
        /// 예시 : [ "3x + 7 + x" ] => [ "4x + 7" ] / [ "x + x + x" ] => [ "3x" ]
        /// </summary>
        /// 1차 시도 : 5 - 8, 10, 12번 실패
        ///     => 분기를 확실하게 나눠야 함
        public string Polynomial(string polynomial)
        {
            string[] numStr = polynomial.Split(" ").ToArray(); // 받은 식을 문자 배열로 생성
            int unclear = 0;
            int constant = 0;
            string answer;
            for (int i = 0; i < numStr.Length; i++)
            {
                if (numStr[i].Contains("x")) // 미지수 x를 포함하는 경우
                {
                    int.TryParse(numStr[i].Replace("x", ""), out int a); // x를 제외하고 숫자로 변환하여 저장
                    if (a == 0) // 0 인 경우 x가 1개이므로
                    {
                        unclear += 1;
                    }
                    else
                    {
                        unclear += a;
                    }
                }
                else // x가 없는 식의 경우, 상수
                {
                    int.TryParse(numStr[i], out int a);
                    constant += a;
                }
            }
            // return 할 string 만들기
            if (unclear > 1) // 계수가 1이상인 경우
            {
                if (constant == 0) // 상수가 0일 때
                {
                    answer = $"{unclear}x"; // 계수값x 만 출력
                }
                else // 상수가 존재할 때
                {
                    answer = $"{unclear}x + {constant}";
                }
            }
            else if (unclear == 1) // 계수가 1인 경우
            {
                if (constant == 0) // 상수가 0일 때
                {
                    answer = $"x"; // 계수만 출력
                }
                else
                {
                    answer = $"x + {constant}";

                }
            }
            else
            {
                if (constant == 0)
                {
                    answer = "";
                }
                else
                {
                    answer = $"{constant}";

                }
            }
            return answer;
        }

        /// <summary>
        /// 제목 : OX퀴즈
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120907
        /// 문제 : 덧셈, 뺄셈 수식들이 'X [연산자] Y = Z' 형태로 들어있는 문자열 배열 quiz가 매개변수로 주어집니다. 
        ///        수식이 옳다면 "O"를 틀리다면 "X"를 순서대로 담은 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ { "3 - 4 = -3", "5 + 6 = 11" } ] => [ { "X", "O" } ] / 
        ///        [ { "19 - 6 = 13", "5 + 66 = 71", "5 - 15 = 63", "3 - 1 = 2" } ] => [ { "O", "O", "X", "O" } ]
        /// </summary>
        /// 
        public string[] OXQuiz(string[] quiz)
        {
            string[] answer = new string[quiz.Length]; // return 할 최종 배열
            for (int count = 0; count < quiz.Length; count++) // 주어진 배열을 돌면서
            {
                string[] formula = quiz[count].Split(" "); // 분할한 string[] 제작
                int.TryParse(formula[0], out int num); // 처음은 무조건 숫자로 시작

                for (int i = 2; i < formula.Length; i++) // 길이만큼 돌면서
                {
                    if (formula[i - 1].Contains("+")) // 그 다음 문자열이 + 인지
                    {
                        int.TryParse(formula[i], out int a);
                        num += a;
                    }
                    else if (formula[i - 1].Contains("-")) // 그 다음 문자열이 - 인지
                    {
                        int.TryParse(formula[i], out int a);
                        num -= a;
                    }
                }
                string find = new string(num.ToString());
                // 값과 결과가 동일한지 확인
                if (find == formula[formula.Length - 1])
                {
                    answer[count] = "O";
                }
                else
                {
                    answer[count] = "X";
                }
            }

            return answer;
        }

        /// <summary>
        /// 제목 : 다음에 올 숫자
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120924
        /// 문제 : 등차수열 혹은 등비수열 common이 매개변수로 주어질 때, 마지막 원소 다음으로 올 숫자를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ { 1, 2, 3, 4 } ] => [ 5 ] / [ { 2, 4, 8 } ] => [ 16 ]
        /// </summary>
        /// 
        public int NextNum(int[] common)
        {
            int answer = 0;
            if (common[1] - common[0] == common[2] - common[1]) // 차가 같은 등차수열
            {
                answer = common[common.Length - 1] + (common[1] - common[0]);
            }
            else // 등차수열이 아니면 무조건 등비수열
            {
                answer = common[common.Length - 1] * (common[1] / common[0]);
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 연속된 수의 합
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120923
        /// 문제 : 연속된 세 개의 정수를 더해 12가 되는 경우는 3, 4, 5입니다. 두 정수 num과 total이 주어집니다. 
        ///        연속된 수 num개를 더한 값이 total이 될 때, 정수 배열을 오름차순으로 담아 return하도록 solution함수를 완성해보세요.
        /// 예시 : [ 3, 12 ] => [ { 3, 4, 5 } ] / [ 5, 15 ] => [ { 1, 2, 3, 4, 5 } ] / [ 4, 14 ] => [ { 2, 3, 4, 5 } ] / 
        ///        [ 5, 5 ] => [ { -1, 0, 1, 2, 3 } ]
        /// </summary>
        /// 
        public int[] ConsecutiveNum(int num, int total)
        {
            int[] answer = new int[num];
            int middle = total / num; // 중간값
            int frontCount = 0; // 중간보다 앞에 오는 갯수
            if (num % 2 == 0) // num이 2의 배수이면
            {
                frontCount = num / 2 - 1; // 앞에 오는 수가 하나 적음
            }
            else
            {
                frontCount = num / 2;
            }
            // 연속된 수를 배열에 저장
            for(int result = middle-frontCount, count = 0; count < num; count++, result++)
            {
                answer[count] = result;
            }
            return answer;
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
        /// 전혀 감도 안옴..... 풀이 해설을 봐도.....
        public static void OverlapLine(int[,] lines)
        {
            
        }
    }
}

