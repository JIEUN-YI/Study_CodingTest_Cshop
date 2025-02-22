namespace Study_CodingTest._20241006study
{
    public class StackQueue_20241123
    {

        /// <summary>
        /// 제목 : 같은 숫자는 싫어
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12906
        /// </summary>

        public static int[] solution(int[] arr)
        {
            /*
            Queue<int> queue = new Queue<int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    queue.Enqueue(arr[i]);
                }
                else if(queue.Peek() == arr[i])
                {
                     continue;
                }
                else
                {
                    queue.Enqueue(arr[i]);
                }
            }
                int[] result = queue.ToArray();
                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
                */
            Stack<int> stack = new Stack<int>();
            // 스택으로 마지막에 입력한 수와 입력할 수가 다른 경우 저장
            for(int i = 0; i < arr.Length; i++)
            {
                if(i == 0) // 첫번째는 무조건 스택에 저장되어야 함
                {
                    stack.Push(arr[0]);
                }
                else if(stack.Peek() == arr[i])
                {
                    continue;
                }
                else
                {
                    stack.Push(arr[i]);
                }
            }
            // 스택의 크기만큼 int 배열 생성
            int[] result = new int[stack.Count];
            // 스택은 후입선출이므로 배열에 알맞게 저장할 것
            for(int i = result.Length - 1; i >= 0; i--)
            {
                result[i] = stack.Pop();
            }
            return result;
            /*
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
            */
        }
    }
}
