using System.Collections;

namespace Study_CodingTest._20240818Study
{   /*
    제목 : 알고리즘 Kit - 해시 - 폰켓몬
    URL : https://school.programmers.co.kr/learn/courses/30/lessons/1845
    문제 : 당신은 폰켓몬을 잡기 위한 오랜 여행 끝에, 홍 박사님의 연구실에 도착했습니다. 
           홍 박사님은 당신에게 자신의 연구실에 있는 총 N 마리의 폰켓몬 중에서 N/2마리를 가져가도 좋다고 했습니다.
           홍 박사님 연구실의 폰켓몬은 종류에 따라 번호를 붙여 구분합니다. 따라서 같은 종류의 폰켓몬은 같은 번호를 가지고 있습니다. 
           예를 들어 연구실에 총 4마리의 폰켓몬이 있고, 각 폰켓몬의 종류 번호가 [3번, 1번, 2번, 3번]이라면 
           이는 3번 폰켓몬 두 마리, 1번 폰켓몬 한 마리, 2번 폰켓몬 한 마리가 있음을 나타냅니다. 
           이때, 4마리의 폰켓몬 중 2마리를 고르는 방법은 다음과 같이 6가지가 있습니다.
            첫 번째(3번), 두 번째(1번) 폰켓몬을 선택
            첫 번째(3번), 세 번째(2번) 폰켓몬을 선택
            첫 번째(3번), 네 번째(3번) 폰켓몬을 선택
            두 번째(1번), 세 번째(2번) 폰켓몬을 선택
            두 번째(1번), 네 번째(3번) 폰켓몬을 선택
            세 번째(2번), 네 번째(3번) 폰켓몬을 선택
           이때, 첫 번째(3번) 폰켓몬과 네 번째(3번) 폰켓몬을 선택하는 방법은 
           한 종류(3번 폰켓몬 두 마리)의 폰켓몬만 가질 수 있지만, 다른 방법들은 모두 두 종류의 폰켓몬을 가질 수 있습니다. 
           따라서 위 예시에서 가질 수 있는 폰켓몬 종류 수의 최댓값은 2가 됩니다.
           당신은 최대한 다양한 종류의 폰켓몬을 가지길 원하기 때문에, 최대한 많은 종류의 폰켓몬을 포함해서 
           N/2마리를 선택하려 합니다. N마리 폰켓몬의 종류 번호가 담긴 배열 nums가 매개변수로 주어질 때,
           N/2마리의 폰켓몬을 선택하는 방법 중, 가장 많은 종류의 폰켓몬을 선택하는 방법을 찾아, 
           그때의 폰켓몬 종류 번호의 개수를 return 하도록 solution 함수를 완성해주세요.
    예시 : [ 3, 1, 2, 3 ] => 2, [ 3, 3, 3, 2, 2, 4 ] => 3, [ 3, 3, 3, 2, 2, 2 ] => 2
           [ 1, 4, 4, 1, 3, 3, 2, 3 ] => 4, [ 1, 4, 1, 2, 3, 2, 3 ] => 3
           [ 1, 1, 1, 1 ] => 1
    
    코멘트 : 프로그래머스에 C++ / Java / JavaScript / Python3 만 존재하여 C#으로 임의로 풀이 후
             임의로 확인함
    */

    public class Hash_20240817
    {
        public static int PickNumPhoneketM(int[] nums)
        {
            int result; // 출력할 결과
            int count = nums.Length / 2; // 선택할 수 있는 폰켓몬의 수
            Hashtable FindM = new Hashtable(); // 해시테이블을 생성
            FindM.Add(0, nums[0]); // 첫번째 값을 저장
            for(int i = 1; i < nums.Length; i++) // 배열의 길이만큼 반복하여
            {
                if (FindM.ContainsValue(nums[i]) == false) // 해시테이블에 중복값이 없는 경우
                {
                    FindM.Add(i, nums[i]); // 해시테이블에 저장
                }
            } // 아니면 다시 반복
            if(FindM.Count > count) // 해시테이블의 크기가 선택할 수 있는 폰켓몬의 수보다 크면
            {
                result = count; // 선택 가능한 폰켓몬의 수 출력
            }
            else result = FindM.Count; // 아니면 해시테이블의 크기 출력

            return result;
            #region 스택을 이용하여 구하는 방식을 생각한 소스코드
            /*int result; // 출력할 결과
            int count = nums.Length / 2; // 선택할 수 있는 폰켓몬의 수
            Stack<int> PickM = new Stack<int>(); // 선택 가능한 폰켓몬의 종류
            PickM.Push(nums[0]);
            // 선택 가능한 폰켓몬의 종류를 스택에 저장하기
            for (int i = 1; i < nums.Length; i++)
            {
                if (PickM.Contains(nums[i]) == false) // 스택에 동일한 폰켓몬의 종류가 없으면
                {
                    PickM.Push(nums[i]); // 저장
                }
                else continue; // 있으면 다음 배열로 넘어가서 반복문 반복
            }

            int[] FindM = PickM.ToArray(); // 그렇게 저장한 폰켓몬의 종류 스택을 배열로 변환

            if (FindM.Length > count) // 배열의 크기가 선택할 수 있는 폰켓몬의 수보다 크면
            {
                result = count; // 선택할 수 있는 폰켓몬의 수를 반환
            }
            else // 아니면
                result = FindM.Length; // 배열의 크기 반환 

            return result;*/
            #endregion
        }
    }
}
