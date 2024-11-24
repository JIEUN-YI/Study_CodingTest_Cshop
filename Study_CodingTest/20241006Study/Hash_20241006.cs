namespace Study_CodingTest._20241006study
{
    public class Hash_20241006
    {

        /// <summary>
        /// 제목 : 의상
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42578
        /// </summary>

        public static void solution(string[,] clothes)
        {
            int answer = 0;
            int valuescount = 1;
            Dictionary<string, string> list = new Dictionary<string, string>();
            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                list.Add(clothes[i, 0], clothes[i, 1]); // 모든 clothes의 종류를 딕셔너리에 포함
            }
            answer = list.Count;

            List<string> values = new List<string>(list.Values);
            List<string> keys = new List<string>(list.Keys);

            for(int i = 0 ; i < keys.Count;i++)
            {
                for(int j = 1; j < values.Count;j++)
                {

                }
            }
            Console.WriteLine(answer);
        }
    }
}
