namespace Study_CodingTest._20241006

{
    public class CodingTest_20241006
    {

        /// <summary>
        /// 제목 : 배열 뒤집기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120821
        /// 문제 : 정수가 들어 있는 배열 num_list가 매개변수로 주어집니다. num_list의 원소의 순서를 거꾸로 뒤집은 배열을 
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2, 3, 4, 5 ] => [ 5, 4, 3, 2, 1 ] / [ 1, 1, 1, 1, 2 ] => [ 2, 1, 1, 1, 1 ] / [ 1, 0, 1, 1, 1, 3, 5 ] => [ 5, 3, 1, 1, 1, 0, 1 ]
        /// </summary>
        public int[] ReverseArray(int[] num_list)
        {
            int[] answer = new int[num_list.Length];

            for (int i = num_list.Length - 1, j = 0; j < num_list.Length; i--, j++)
            {
                answer[j] = num_list[i];
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 문자열 안에 문자열
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120908
        /// 문제 : 문자열 str1, str2가 매개변수로 주어집니다. str1 안에 str2가 있다면 1을 없다면 2를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( "ab6CDE443fgh22iJKlmn1o", "6CD" ) => ( 1 ) / ( "ppprrrogrammers", "pppp" ) => ( 2 ) / ( "AbcAbcA", "AAA" ) => ( 2 )
        /// </summary>
        public int StrInStr(string str1, string str2)
        {
            int answer = 0;
            if (str1.Contains(str2) == true)
            {
                answer = 1;
            }
            else
            {
                answer = 2;
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 배열의 유사도
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120903
        /// 문제 : 두 배열이 얼마나 유사한지 확인해보려고 합니다. 문자열 배열 s1과 s2가 주어질 때 같은 원소의 개수를 
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : ( ["a", "b", "c"], ["com", "b", "d", "p", "c"] ) => ( 2 ) / ( ["n", "omg"], ["m", "dot"] ) => ( 0 ) 
        /// </summary>
        public int SimularArray(string[] s1, string[] s2)
        {
            int answer = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        answer++;
                    }
                    else continue;
                }
            }
            return answer;
        }

        /// <summary>
        /// 제목 : 인덱스 바꾸기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120895
        /// 문제 : 문자열 my_string과 정수 num1, num2가 매개변수로 주어질 때, 
        ///        my_string에서 인덱스 num1과 인덱스 num2에 해당하는 문자를 바꾼 문자열을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : ( "hello", 1, 2 ) => ( "hlelo" ) / ( "I love you", 3, 6 ) => ( "I l veoyou" )
        /// </summary>
        public string IndexChange(string my_string, int num1, int num2)
        {
            string answer;
            char temp;
            char[] example = my_string.ToCharArray();
            temp = example[num1];
            example[num1] = example[num2];
            example[num2] = temp;

            answer = string.Concat(example); // 문자를 연결하여 저장
            return answer;
        }

        /// <summary>
        /// 제목 : 배열 원소의 길이
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120854
        /// 문제 : 문자열 배열 strlist가 매개변수로 주어집니다. strlist 각 원소의 길이를 담은 배열을 retrun하도록 solution 함수를 완성해주세요.
        /// 예시 : ["We", "are", "the", "world!"] => [2, 3, 3, 6] / ["I", "Love", "Programmers."] => [1, 4, 12]
        /// </summary>
        public int[] ArrayLength(string[] strlist)
        {
            int[] answer = new int[strlist.Length];
            for (int i = 0; i < strlist.Length; i++)
            {
                char[] ex = strlist[i].ToCharArray();
                answer[i] = ex.Length;
            }
            return answer;

        }
    }
}
