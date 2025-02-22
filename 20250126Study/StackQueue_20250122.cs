namespace Study_CodingTest._20250126study
{
    public class StackQueue_20250126
    {

        /// <summary>
        /// 제목 : 기능 개발
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42586
        /// 문제 : 프로그래머스 팀에서는 기능 개선 작업을 수행 중입니다. 각 기능은 진도가 100%일 때 서비스에 반영할 수 있습니다.
        ///        또, 각 기능의 개발속도는 모두 다르기 때문에 뒤에 있는 기능이 앞에 있는 기능보다 먼저 개발될 수 있고,
        ///        이때 뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포됩니다.
        ///        먼저 배포되어야 하는 순서대로 작업의 진도가 적힌 정수 배열 progresses와 각 작업의 개발 속도가 적힌 정수 배열 speeds가 주어질 때 
        ///        각 배포마다 몇 개의 기능이 배포되는지를 return 하도록 solution 함수를 완성하세요.
        /// 예시 : [ 93, 30, 50 ] [ 1, 30, 5 ] => [ 2, 1 ] / [ 95, 90, 99, 99, 80, 99 ] [ 1, 1, 1, 1, 1, 1 ] => [ 1, 3, 2 ]
        /// </summary>
        public static void Development(int[] progresses, int[] speeds)
        {
            /*
            int[] answer = new int[progresses.Length]; // 결과값 인출 배열

            // Queue를 선언
            Queue<int> queue = new Queue<int>();
            // progresses의 원소로 초기화
            foreach (int i in progresses)
            {
                queue.Enqueue(i);
            }

            int day = 1; // 업무 일수
            int work; // 가장 먼저 작업할 작업의 완료도
            int count = 0; // 작업 개수

            for (int i = 0; i < speeds.Length; i++)
            {
                do
                {
                    work = queue.Peek();
                    work += speeds[i] * day;
                    if (work  >= 100)
                    {
                        count++;
                        queue.Dequeue();
                    }
                    else
                    {
                        day++;
                    }
                }
                while (work <= 100);
            }
            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
            */

        }
    }
}

