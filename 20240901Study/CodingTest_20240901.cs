using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_CodingTest._20240901Study
{
    public class CodingTest_20240901
    {
        /// <summary>
        /// 제목 : 중복된 숫자 개수 
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120583
        /// 문제 : 정수가 담긴 배열 array와 정수 n이 매개변수로 주어질 때, 
        ///        array에 n이 몇 개 있는 지를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : ( [ 1, 1, 2, 3, 4, 5 ] ,1 ) => 2, ( [ 0, 2, 3, 4 ] ,1 ) => 0
        /// </summary>
        public int FindOverlapNum(int[] array, int n)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == n)
                {
                    count++;
                }
                else continue;
            }
            return count;
        }
        /// <summary>
        /// 제목 : 머쓱이보다 키 큰 사람
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120585
        /// 문제 : 머쓱이는 학교에서 키 순으로 줄을 설 때 몇 번째로 서야 하는지 궁금해졌습니다. 
        ///        머쓱이네 반 친구들의 키가 담긴 정수 배열 array와 머쓱이의 키 height가 매개변수로 주어질 때, 
        ///        머쓱이보다 키 큰 사람 수를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : ( [ 149, 180, 192, 170 ], 167 ) => 3, ( [ 180, 120, 140 ], 190 ) => 0 
        /// </summary>
        public int FindTaller(int[] array, int n)
        {
            int count = 0;
            for(int i = 0;i < array.Length; i++)
            {
                if(array[i] > n)
                {
                    count++;
                }
                else continue ;
            }

            return count;
        }
        /// <summary>
        /// 제목 : 배열 두 배 만들기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120809
        /// 문제 : 정수 배열 numbers가 매개변수로 주어집니다. 
        ///        numbers의 각 원소에 두배한 원소를 가진 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2, 3, 4, 5 ] => [ 2, 4, 6, 8, 10 ], [ 1, 2, 100, -99, 1, 2, 3 ] => [ 2, 4, 200, -198, 2, 4, 6 ]
        /// </summary>
        public int[] DoubleArray(int[] array)
        {
            for(int i = 0; i<array.Length; i++)
            {
                array[i] *= 2;
            }
            return array;
        }
        /// <summary>
        /// 제목 : 중앙값 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120811
        /// 문제 : 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다. 
        ///        예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다. 정수 배열 array가 매개변수로 주어질 때, 
        ///        중앙값을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 1, 2, 7, 10, 11 ] => 7, [ 9, -1, 0 ] => 0
        /// </summary>
        public int FindMiddle(int[] array)
        {
            Array.Sort(array);
            int result = array[array.Length / 2];
            return result;
        }
        /// <summary>
        /// 제목 : 짝수는 싫어요
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120813
        /// 문제 : 정수 n이 매개변수로 주어질 때, 
        ///        n 이하의 홀수가 오름차순으로 담긴 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 10 ) => [ 1, 3, 5, 7, 9 ], ( 15 ) => [ 1, 3, 5, 7, 9, 11, 13, 15 ]
        /// </summary>
        public int[] FindOddNum(int n)
        {
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
                else continue;
            }
            int[] result = new int[count];
            for(int i = 0, j = 1 ; i < count ; j++)
            {
                if (j % 2 != 0)
                {
                    result[i] = j;
                    i++;
                }
                else continue;
            }
            return result;

        }
        /// <summary>
        /// 제목 : 피자 나눠 먹기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120814
        /// 문제 : 머쓱이네 피자가게는 피자를 일곱 조각으로 잘라 줍니다. 피자를 나눠먹을 사람의 수 n이 주어질 때,
        ///        모든 사람이 피자를 한 조각 이상 먹기 위해 필요한 피자의 수를 return 하는 solution 함수를 완성해보세요.
        /// 예시 : ( 7 ) = > 1, ( 1 ) => 1
        /// </summary>
        public int SharePizza(int n)
        {
            int result;
            if( n % 7 == 0)
            {
                result = n / 7;
            }
            else
            {
                result = n / 7 + 1 ;
            }
            return result;
        }
        /// <summary>
        /// 제목 : 옷가게 할인받기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120818
        /// 문제 : 머쓱이네 옷가게는 10만 원 이상 사면 5%, 30만 원 이상 사면 10%, 50만 원 이상 사면 20%를 할인해줍니다. 
        ///        구매한 옷의 가격 price가 주어질 때, 지불해야 할 금액을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : ( 150,000 ) => 142,500 , ( 580,000 ) => 464,000
        /// </summary>
        public int HowMuch(int n)
        {
            int result = 0;

            if (n >= 500000)
            {
                result = (int)Math.Floor(n * 0.8);// Math.Floor() 버림 함수
            }
            else if (n >= 300000)
            {
                result = (int)Math.Floor(n * 0.9);
            }
            else if (n >= 100000)
            {
                result = (int)Math.Floor(n * 0.95);
            }
            else result = n; // 할인되지 않는 가격 그대로 저장 필수
            return result;
        }
        /// <summary>
        /// 제목 : 아이스 아메리카노
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120819
        /// 문제 : 머쓱이는 추운 날에도 아이스 아메리카노만 마십니다. 
        ///        아이스 아메리카노는 한잔에 5,500원입니다. 머쓱이가 가지고 있는 돈 money가 매개변수로 주어질 때,
        ///        머쓱이가 최대로 마실 수 있는 아메리카노의 잔 수와 남는 돈을 순서대로 담은 배열을 return 하도록 
        ///        solution 함수를 완성해보세요.
        /// 예시 : ( 5500 ) => [ 1, 0 ]. ( 15000 ) => [ 2, 4000 ]
        /// </summary>
        public int[] HowMany(int n)
        {
            int[] result = new int[2];
            result[0] = n / 5500;
            result[1] = n - 5500 * result[0];

            return result;
        }
        /// <summary>
        /// 제목 : 배열 자르기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120833
        /// 문제 : 정수 배열 numbers와 정수 num1, num2가 매개변수로 주어질 때, 
        ///        numbers의 num1번 째 인덱스부터 num2번째 인덱스까지 자른 정수 배열을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : ( [ 1, 2, 3, 4, 5 ], 1, 3 ) => [ 2, 3, 4 ], ( [ 1, 3, 5 ], 1, 2 ) => [ 3, 5 ]
        /// </summary>
        public int[] CutArray(int[] array, int num1, int num2)
        {
            int[] result = new int[num2 - num1 + 1];
            for (int i = 0, j = num1 ; j <= num2 ; i++, j++)
            {
                result[i] = array[j];
            }
            return result;
        }
        /// <summary>
        /// 제목 : 개미 군단
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120837
        /// 문제 : 개미 군단이 사냥을 나가려고 합니다. 개미군단은 사냥감의 체력에 딱 맞는 병력을 데리고 나가려고 합니다. 
        ///        장군개미는 5의 공격력을, 병정개미는 3의 공격력을 일개미는 1의 공격력을 가지고 있습니다.
        ///        예를 들어 체력 23의 여치를 사냥하려고 할 때, 일개미 23마리를 데리고 가도 되지만, 
        ///        장군개미 네 마리와 병정개미 한 마리를 데리고 간다면 더 적은 병력으로 사냥할 수 있습니다. 
        ///        사냥감의 체력 hp가 매개변수로 주어질 때, 사냥감의 체력에 딱 맞게 최소한의 병력을 구성하려면 
        ///        몇 마리의 개미가 필요한지를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( 23 ) => 5, ( 24 ) => 6, ( 999 ) => 201
        /// </summary>
        public int CorpsAnt(int n)
        {
            int result = 0;
            if (n >= 5)
            {
                result = n / 5;
                n = n % 5;
            }
            if (n >= 3)
            {
                result += n / 3;
                n = n % 3;
            }
            if (n >= 1)
            {
                result += n / 1;
                n = n % 1;
            }

            return result;
        }
    
    }
}
