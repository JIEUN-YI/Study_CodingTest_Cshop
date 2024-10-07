using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Study_CodingTest._20240922Study
{
    public class CodingTest_20240922
    {
        /// <summary>
        /// 제목 : 숨어있는 숫자의 덧셈(1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120851
        /// 문제 : 문자열 my_string이 매개변수로 주어집니다. my_string안의 모든 자연수들의 합을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( "aAb1B2cC34oOp" ) => 10, ( "1a2b3c4d123" ) => 16
        /// </summary>
        /// 
        public static void HideNumAdd(string my_string)
        {
            string isNum = Regex.Replace(my_string, @"[^0-9]", "");
            // 문자열에서 숫자만 추출하는 함수
            int.TryParse(isNum, out int num);

        }

        /// <summary>
        /// 제목 : 암호 해독
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120892
        /// 문제 : 군 전략가 머쓱이는 전쟁 중 적군이 다음과 같은 암호 체계를 사용한다는 것을 알아냈습니다.
        ///         - 암호화된 문자열 cipher를 주고받습니다.
        ///         - 그 문자열에서 code의 배수 번째 글자만 진짜 암호입니다.
        ///        문자열 cipher와 정수 code가 매개변수로 주어질 때 해독된 암호 문자열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( "dfjardstddetckdaccccdegk", 4 ) => "attack", ( "pfqallllabwaoclk", 2 ) => 	"fallback"
        /// </summary>
        /// 
        public static string FindCode(string cipher , int code)
        {
            List<char> Findcode = new List<char>(); // 코드를 찾을 리스트 선언
            for(int i = 0; i < cipher.Length; i++)
            {
                if((i+1) % code == 0)
                {
                    Findcode.Add(cipher[i]); // 올바른 코드를 리스트에 추가
                }
            }
            string answer = new string(Findcode.ToArray());
            Console.WriteLine(answer);
            return answer;
        }
        /// <summary>
        /// 제목 : 대문자와 소문자
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120893
        /// 문제 : 문자열 my_string이 매개변수로 주어질 때, 대문자는 소문자로 소문자는 대문자로 변환한 문자열을 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : ( "cccCCC" ) => ( "CCCccc" ), ( "abCdEfghIJ"	) => ( "ABcDeFGHij" )
        /// </summary>
        /// 
        public static string ChangeChar(string my_string)
        {
            char[] change = my_string.ToCharArray();
            for(int i = 0 ; i < change.Length; i++)
            {
                // 대문자인 경우
                if (char.IsUpper(change[i]))
                {
                    // 소문자로 변경
                    change[i] = char.ToLower(change[i]);
                }
                // 소문자인 경우
                else if (char.IsLower(change[i]))
                {
                    // 대문자로 변경
                    change[i] = char.ToUpper(change[i]);
                }
            }
            string answer = new string(change);
            return answer;
        }
        /// <summary>
        /// 제목 : 가장 큰 수 찾기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120899
        /// 문제 : 정수 배열 array가 매개변수로 주어질 때, 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [1, 8, 3] => [8, 1], [9, 10, 11, 8] => [11, 2]
        /// </summary>
        /// 
        public static int[] FindBiggestNum(int[] array)
        {
            int[] findNum = new int[2];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    findNum[0] = array[i - 1];
                    findNum[1] = i - 1;
                }
                else if (array[i - 1] <= array[i])
                {
                    findNum[0] = array[i];
                    findNum[1] = i;
                }
            }
            return findNum;
        }
        /// <summary>
        /// 제목 : n의 배수 고르기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120905
        /// 문제 : 정수 n과 정수 배열 numlist가 매개변수로 주어질 때, numlist에서 n의 배수가 아닌 수들을 제거한 배열을 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : ( 3, [4, 5, 6, 7, 8, 9, 10, 11, 12] ) => [6, 9, 12], (5, [1, 9, 3, 10, 13, 5] ) => [10, 5],
        ///        ( 12, [2, 100, 120, 600, 12, 12] ) => [120, 600, 12, 12]
        /// </summary>
        /// 
        public static int[] FindNumMultiple(int n, int[] numlist)
        {
            List<int> list = new List<int>();
            int j = 0;
            for (int i = 0; i < numlist.Length; i++)
            {
                if (numlist[i] % n == 0)
                {
                    list.Add(numlist[i]);
                }
            }
            int[] answer = list.ToArray();
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 가위 바위 보
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120839
        /// 문제 : 가위는 2 바위는 0 보는 5로 표현합니다. 가위 바위 보를 내는 순서대로 나타낸 문자열 rsp가 매개변수로 주어질 때, 
        ///        rsp에 저장된 가위 바위 보를 모두 이기는 경우를 순서대로 나타낸 문자열을 return하도록 solution 함수를 완성해보세요.
        /// 예시 : ( 2 ) => ( 0 ), ( 205 ) => ( 052 )
        /// </summary>
        /// 
        public static void RockScissorsPaper(string rsp)
        {
            int[] rspInt = new int[rsp.Length];
            for(int i = 0;i < rspInt.Length; i++)
            {
                // 문자열을 하나씩 돌면서 확인하여 비교
                // if문으로 비교하여 승리값 배치
                // stringbuilder의 append를 사용하여 합체
            }
        }


        /// <summary>
        /// 제목 : 최대값 만들기(2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120862
        /// 문제 : 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소 중 두 개를 곱해 만들 수 있는 최댓값을 return하도록 
        ///        solution 함수를 완성해주세요.
        /// 예시 : [1, 2, -3, 4, -5] => 15, [0, -31, 24, 10, 1, 9] => 240, [10, 20, 30, 5, 5, 20, 5] => 600
        /// </summary>
        /// 

        /// <summary>
        /// 제목 : 주사위의 개수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120845
        /// 문제 : 머쓱이는 직육면체 모양의 상자를 하나 가지고 있는데 이 상자에 정육면체 모양의 주사위를 최대한 많이 채우고 싶습니다. 
        ///        상자의 가로, 세로, 높이가 저장되어있는 배열 box와 주사위 모서리의 길이 정수 n이 매개변수로 주어졌을 때, 
        ///        상자에 들어갈 수 있는 주사위의 최대 개수를 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : ( [1, 1, 1], 1 ) => 1, ( [10, 8, 6], 3 ) => 12
        /// </summary>
        /// 
        public static int CountDice(int[] box, int n)
        {
            int[] countAnwer = new int[3];
            for(int i = 0; i < box.Length; i++)
            {
                countAnwer[i] = box[i] / n; //각 변에 필요한 주사위 갯수 저장
            }
            int answer = 1;
            for (int i = 0; i<countAnwer.Length; i++)
            {
                answer *= countAnwer[i]; // 각 항목을 곱하기
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 문자열 정렬하기(1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120850
        /// 문제 : 문자열 my_string이 매개변수로 주어질 때, my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를 return 하도록
        ///        solution 함수를 작성해보세요.
        /// 예시 : "hi12392" => [1, 2, 2, 3, 9], "p2o4i8gj2" => [2, 2, 4, 8], "abcde0" => [0]
        /// </summary>
        /// 

        /// <summary>
        /// 제목 : 직각삼각형 출력하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120823
        /// 문제 : "*"의 높이와 너비를 1이라고 했을 때, "*"을 이용해 직각 이등변 삼각형을 그리려고합니다. 
        ///        정수 n 이 주어지면 높이와 너비가 n 인 직각 이등변 삼각형을 출력하도록 코드를 작성해보세요.
        /// 예시 : ( 3 ) => *
        ///                 **
        ///                 ***
        /// </summary>
        ///
        public static void MakingTriangle(int n)
        {
            Console.Clear();
            // int.TryParse(Console.ReadLine(), out int n); // 프로그래머스 제출 시 포함
            int[,] triangle = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i) // j와 i 열/행 구별이 필요함 x, y로 계산해도 좋은 듯
                    {
                        Console.Write("*");
                    }
                    continue;
                }
                Console.Write("\n");
                continue;
            }
        }
    }
}
