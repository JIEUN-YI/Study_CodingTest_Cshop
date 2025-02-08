using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_CodingTest._250209
{
    public class StackQueue_250209
    {

        /// <summary>
        /// 제목 : 올바른 괄호
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12909
        /// 문제 : 괄호가 바르게 짝지어졌다는 것은 '(' 문자로 열렸으면 반드시 짝지어서 ')' 문자로 닫혀야 한다는 뜻입니다. 
        ///        예를 들어"()()" 또는 "(())()" 는 올바른 괄호입니다. 
        ///        ")()(" 또는 "(()(" 는 올바르지 않은 괄호입니다. '(' 또는 ')' 로만 이루어진 문자열 s가 주어졌을 때, 
        ///        문자열 s가 올바른 괄호이면 true를 return 하고, 올바르지 않은 괄호이면 false를 return 하는 solution 함수를 완성해 주세요.
        /// 예시 : [ "()()" ] => [ true ] / [ "(())()" ] => [ true ] / [ ")()(" ] => [ false ] / [ "(()(" ] => [ false ]
        /// </summary>
        /// 
        public bool RightParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            char[] chars = s.ToCharArray(); // 받은 문자열을 문자 배열로 변환

            for(int i = 0; i < chars.Length; i++) // 배열이 전부 도는 동안
            {
                if(stack.Count == 0)
                {
                    if (chars[i] == ')') // 맨 처음이 닫힌 괄호인 경우 false
                    {
                        return false;
                    }
                    else // 맨 처음이 여는 괄호인 경우 시작
                    {
                        stack.Push(chars[i]);
                    }
                }
                else if(stack.Peek() == chars[i]) // 스택에서 나올 괄호와 배열에서 넣을 괄호가 같은 경우
                {
                    stack.Push(chars[i]); // 입력
                }    
                else if(stack.Peek() != chars[i]) // 서로 다른 괄호의 경우
                {
                    stack.Pop(); // 스택에서 제거
                }
            }

            if(stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
