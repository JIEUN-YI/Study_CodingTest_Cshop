namespace Study_CodingTest._250223
{
    public class StackQueue_250223
    {
        /// <summary>
        /// 제목 : 프로세스
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/42587
        /// 문제 : 운영체제의 역할 중 하나는 컴퓨터 시스템의 자원을 효율적으로 관리하는 것입니다. 
        ///        이 문제에서는 운영체제가 다음 규칙에 따라 프로세스를 관리할 경우 특정 프로세스가 몇 번째로 실행되는지 알아내면 됩니다.
        ///        1. 실행 대기 큐(Queue)에서 대기중인 프로세스 하나를 꺼냅니다.
        ///        2. 큐에 대기중인 프로세스 중 우선순위가 더 높은 프로세스가 있다면 방금 꺼낸 프로세스를 다시 큐에 넣습니다.
        ///        3. 만약 그런 프로세스가 없다면 방금 꺼낸 프로세스를 실행합니다.
        ///           3.1 한 번 실행한 프로세스는 다시 큐에 넣지 않고 그대로 종료됩니다.
        ///        예를 들어 프로세스 4개 [A, B, C, D]가 순서대로 실행 대기 큐에 들어있고, 
        ///        우선순위가 [2, 1, 3, 2]라면 [C, D, A, B] 순으로 실행하게 됩니다.
        ///        현재 실행 대기 큐(Queue)에 있는 프로세스의 중요도가 순서대로 담긴 배열 priorities와, 
        ///        몇 번째로 실행되는지 알고싶은 프로세스의 위치를 알려주는 location이 매개변수로 주어질 때, 
        ///        해당 프로세스가 몇 번째로 실행되는지 return 하도록 solution 함수를 작성해주세요.
        /// 예시 : [ [2, 1, 3, 2], 2 ] => [ 1 ] / [ [1, 1, 9, 1, 1, 1], 0 ] => [ 5 ]
        /// </summary>
        /// 1차 : 2 ~ 4, 6 ~ 13, 16 ~ 20 번 테스트 케이스 실패
        public static int Process(int[] priorities, int location)
        {
            int result = 0; // 결과 변수
            // prioties에서 받은 우선순위를 queue에 저장
            Queue<Items> queue = new Queue<Items>();

            for(int i = 0; i < priorities.Length; i++)
            {
                Items item = new Items();
                item.index = i;
                item.prio = priorities[i];
                queue.Enqueue(item);
            }

            // 큐의 맨 앞의 우선순위가 가장 높을 때까지 반복해야 함
            int maxPrio = priorities.Max(); // prioities에서 가장 높은 값
            bool isChecked = false;

            do
            {
                Items answer = queue.Peek(); // 큐에서 다음에 제거할 것
                foreach (Items item in queue) // 남은 모든 큐를 돌면서
                {
                    if (answer.prio < item.prio) // answer의 우선순위가 작으면
                    {
                        queue.Dequeue(); // 앞에 제거 후 
                        queue.Enqueue(answer); // 큐에 추가
                        break; // 큐에 추가하면 종료
                    }
                }
                answer = queue.Peek();
                if (answer.prio == maxPrio)
                {
                    isChecked = true;
                }
            } while (!isChecked);

            Items[] items = queue.ToArray(); // 배열화
            for(int i = 0; i<items.Length; i++) // 배열을 돌면서
            {
                if(items[i].index == location) // index 값이 location과 같은 items 배열의 인덱스 값 + 1
                {
                    result = i+1;
                    break;
                }
            }
            Console.WriteLine(result);
            return result;
        }
        public class Items
        {
            public int index;
            public int prio;
        }
    }
}
