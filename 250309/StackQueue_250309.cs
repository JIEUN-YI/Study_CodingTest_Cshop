namespace Study_CodingTest._250309
{
    public class StackQueue_250309
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
        /// 1차 : 2 ~ 4, 6 ~ 13, 16 ~ 20번 테스트 케이스 실패
        public int Process(int[] priorities, int location)
        {
            // queue를 선언
            Queue<Items> queue = new Queue<Items>();
            int index = 0; // 함께 저장할 인덱스 값
            foreach (int pri in priorities) // 원하는 Items에 맞춰서 queue 생성
            {
                Items item = new Items();
                item.index = index;
                item.prio = pri;
                index++;
                queue.Enqueue(item);
            }
            int[] result = new int[priorities.Length]; // 출력 결과를 인덱스를 저장할 배열
            int count = 0; // 저장할 배열의 인덱스 값
            while (queue.Count > 0) // 큐의 용량이 있는 동안
            {
                Items[] find = queue.ToArray(); // Items 배열로 queue를 변환
                Items item = queue.Dequeue(); // 맨 앞의 값 가져오기

                int max = find.Max(i => i.prio); // 최대값을 찾아서
                if (item.prio == max) // 우선순위 최대값과 맨 앞에 값의 우선순위가 같으면
                {
                    result[count] = item.index; // 인덱스 값 저장
                    count++; // 배열의 인덱스 상승
                }
                else // 아니면
                {
                    queue.Enqueue(item); // 큐에 삽임
                }
            }
            for (int i = 0; i < result.Length; i++) // 완성된 배열을 확인하여
            {
                if (result[i] == location) // 값이 location과 같으면
                {
                    return i + 1;
                }
            }
            return 0;
        }
    }
    public class Items
    {
        public int prio;
        public int index;
    }
}

