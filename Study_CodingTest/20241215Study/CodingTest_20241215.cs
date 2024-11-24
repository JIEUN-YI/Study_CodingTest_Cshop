namespace Study_CodingTest._20241215Study
{
    public class CodingTest_20241215
    {
        /// <summary>
        /// 제목 : 자릿수 더하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120906
        /// 문제 : 정수 n이 매개변수로 주어질 때 n의 각 자리 숫자의 합을 return하도록 solution 함수를 완성해주세요
        /// 예시 :  [1234] => [10] / [930211] => [16]
        /// </summary>
        public int AddNumbering(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10; // 나머지는 더하고
                num = num / 10; // 결과는 num으로 다음 계산을 지속
            }
            return sum;
        }

        /// <summary>
        /// 제목 : 삼각형의 완성조건 (1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120889
        /// 문제 : 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
        ///        가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다. 
        ///        삼각형의 세 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다.
        ///        세 변으로 삼각형을 만들 수 있다면 1, 만들 수 없다면 2를 return하도록 solution 함수를 완성해주세요.
        /// 예시 :  [1, 2, 3] => [2] / [3, 6, 2] => [2] / [199, 72, 222] => [1]
        /// </summary>
        public int CheckTriangle(int[] sides)
        {
            Array.Sort(sides); // 오름차순 정렬
            Array.Reverse(sides); // 내림차순으로 변환
            if (sides[0] < sides[1] + sides[2])
            {
                Console.WriteLine("1");
                return 1;
            }
            else
            {
                Console.WriteLine("2");
                return 2;
            }
        }


        /// <summary>
        /// 제목 : 순서쌍의 개수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120836
        /// 문제 : 순서쌍이란 두 개의 숫자를 순서를 정하여 짝지어 나타낸 쌍으로 (a, b)로 표기합니다. 
        ///        자연수 n이 매개변수로 주어질 때 두 숫자의 곱이 n인 자연수 순서쌍의 개수를 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 :  [20] => [6] / [100] => [9]
        /// </summary>
        public int CountNumbers(int n)
        {
            // 약수의 갯수 구하기?
            int count = 0;
            for(int i = 1; i <= n/2; i++)
            {
                if( n % i == 0)
                {
                    count++;
                }
                else continue;
            }
            count++; // 자기 자신을 포함
            return count;
        }


        /// <summary>
        /// 제목 : 제곱수 판별하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120909
        /// 문제 : 어떤 자연수를 제곱했을 때 나오는 정수를 제곱수라고 합니다. 
        ///        정수 n이 매개변수로 주어질 때, n이 제곱수라면 1을 아니라면 2를 return하도록 solution 함수를 완성해주세요.
        /// 예시 :  [144] => [1] / [976] => [2]
        /// </summary>
        public static int Square(int n)
        {
            // i가 n이 되기 전까지
            for(int i = 1; i < n; i++)
            {
                if (n == i * i) 
                {
                    return 1;
                }
                else
                    continue;
            }
            return 2;
        }


        /// <summary>
        /// 제목 : 피자 나눠 먹기 (3)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120816
        /// 문제 : 머쓱이네 피자가게는 피자를 두 조각에서 열 조각까지 원하는 조각 수로 잘라줍니다. 
        ///        피자 조각 수 slice와 피자를 먹는 사람의 수 n이 매개변수로 주어질 때,
        ///        n명의 사람이 최소 한 조각 이상 피자를 먹으려면 최소 몇 판의 피자를 시켜야 하는지를 return 하도록
        ///        solution 함수를 완성해보세요.
        /// 예시 :  [7, 10] => [2] / [4, 12] => [3]
        /// </summary>
        public int SharingPizza(int slice, int n)
        {
            // 나머지가 0이면
            if( n % slice == 0)
            {
                return n / slice; // 값 출력
            }
            // 나누어 떨어지지 않으면
            else if( n % slice != 0)
            {
                return n / slice + 1;
            }
            return 0;
        }
    }
}
