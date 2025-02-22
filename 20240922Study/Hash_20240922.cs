using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Study_CodingTest._20240922Study
{
    /// <summary>
    /// 제목 : 전화번호 목록
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42577
    /// </summary>
    /// 
    public class Hash_20241006
    {
        public void solution(string[] phone_book)
        {
            /* 푸는 방법이 감이 오지 않아서 우선 생각한 방식 기록
             * 일단 받은 전화번호가 string[]인 점
             *  1. 가장 짧은 길이? 값이 앞으로 오게 해서 phone_book[0]의 값이
             *     다른 값와 동일한 부분이 있는지 비교하면 될 것 같다고 생각함
             *  2. 문제는 string 값을 비교하는 것
             *     - foreach문을 사용하여 string 내부의 문자를 char형으로 비교?
             *       : 문제는 string내부의 문자가 동일한 것이 아닌 같은 순서로 배열된 문자열이
             *         한 번에...되기...? 어렵다....
             *         
             *  => startsWith : c#에도 비슷한 함수를 찾아보기
             */
        }
    }
}
