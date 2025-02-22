using System.Data; // Compute를 문자열 계산에 사용하기 위해 선언

namespace Study_CodingTest._250223
{
    public class CodingTest_250223
    {
        /// <summary>
        /// 제목 : 문자열 계산하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120902
        /// 문제 : my_string은 "3 + 5"처럼 문자열로 된 수식입니다. 
        ///        문자열 my_string이 매개변수로 주어질 때, 수식을 계산한 값을 return 하는 solution 함수를 완성해주세요.
        /// 예시 : [ "3 + 4" ] => [ 7 ]
        /// </summary>
        /// 제대로 작동하지만 프로그래머스 에러 발생
        /// error CS0234: The type or namespace name `Data' does not exist in the namespace `System'. Are you missing `System.Data' assembly reference?
        /// using 문 추가하여도 에러 발생
        public static int CalculateNum(string my_string)
        {
            DataTable dt = new DataTable();

            int num = (int)dt.Compute(my_string, " "); // Compute를 사용

            Console.WriteLine(num);
            return num;
        }

        /// <summary>
        /// 제목 : 삼각형의 완성조건 (2)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120868
        /// 문제 : 선분 세 개로 삼각형을 만들기 위해서는 다음과 같은 조건을 만족해야 합니다.
        ///        가장 긴 변의 길이는 다른 두 변의 길이의 합보다 작아야 합니다. 
        ///        삼각형의 두 변의 길이가 담긴 배열 sides이 매개변수로 주어집니다.
        ///        나머지 한 변이 될 수 있는 정수의 개수를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 2 ] => [ 1 ] / [ 3, 6 ] => [ 5 ] / [ 11, 7 ] => [ 13 ]
        /// </summary>
        /// 
        public int TermsTriangle(int[] sides)
        {
            int minNum = Math.Max(sides[0], sides[1]) - Math.Min(sides[0], sides[1]) + 1; // 삼각형 조건의 최소값
            int maxNum = sides[0] + sides[1] - 1; // 삼각형 조건의 최대값

            int answer = maxNum - minNum + 1; // 가능한 값의 개수

            return answer;
        }

        /// <summary>
        /// 제목 : 영어가 싫어요
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120894
        /// 문제 : 영어가 싫은 머쓱이는 영어로 표기되어있는 숫자를 수로 바꾸려고 합니다. 
        ///        문자열 numbers가 매개변수로 주어질 때, numbers를 정수로 바꿔 return 하도록 solution 함수를 완성해 주세요.
        /// 예시 : [ "onetwothreefourfivesixseveneightnine" ] => [ 123456789 ] / [ "onefourzerosixseven" ] => [ 14067 ]
        /// </summary>
        /// 
        public long ChangeNum(string numbers)
        {
            List<char> answerList = new List<char>();
            Dictionary<string, char> dic = new Dictionary<string, char>(); // dictionary 저장
            dic.Add("zero", '0');
            dic.Add("one", '1');
            dic.Add("two", '2');
            dic.Add("three", '3');
            dic.Add("four", '4');
            dic.Add("five", '5');
            dic.Add("six", '6');
            dic.Add("seven", '7');
            dic.Add("eight", '8');
            dic.Add("nine", '9');

            char[] chars = numbers.ToCharArray(); // string을 문자 배열로 저장하여
            Queue<char> queue = new Queue<char>();
            foreach (char c in chars) // 큐에 저장
            {
                queue.Enqueue(c);
            }

            List<char> english = new List<char>();
            while (queue.Count > 0) // 큐의 용량이 있는 동안
            {
                english.Add(queue.Dequeue()); // 큐에서 문자를 빼오고
                string my_string = new string(english.ToArray()); // 문자열로 생성
                if (dic.ContainsKey(my_string)) // 동일한 문자열이 dictionary에 있으면
                {
                    answerList.Add(dic[my_string]); // 결과 리스트에 숫자(문자)를 저장
                    english.Clear(); // english 리스트 초기화
                }
                else // 동일한 문자열이 없으면
                {
                    continue; // 계속
                }
            }

            string intAnswer = new string(answerList.ToArray()); // list 문자열로 변환
            long.TryParse(intAnswer, out long value); //문자열을 숫자로 변환
            return value;
        }

        /// <summary>
        /// 제목 : 구술을 나누는 경우의 수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120840
        /// 문제 : 머쓱이는 구슬을 친구들에게 나누어주려고 합니다. 구슬은 모두 다르게 생겼습니다. 
        ///        머쓱이가 갖고 있는 구슬의 개수 balls와 친구들에게 나누어 줄 구슬 개수 share이 매개변수로 주어질 때, 
        ///        balls개의 구슬 중 share개의 구슬을 고르는 가능한 모든 경우의 수를 return 하는 solution 함수를 완성해주세요.
        /// 예시 : [ 3, 2 ] => [ 3 ] / [ 5, 3 ] => [ 10 ]
        /// </summary>
        /// 5 ~ 7, 18 ~ 23, 25 ~ 35 테스트 케이스 실패 => 나눗셈의 int 값 변환 때문으로 추정
        public static void ShareBall(int balls, int share)
        {
            /* 5 ~ 7, 18 ~ 23, 25 ~ 35 테스트 케이스 실패 => 나눗셈의 int 값 변환 때문으로 추정
            int num1 = 1; // 공식에서 분자 부분
            for(int i = 1; i <= balls; i++)
            {
                num1 *= i;
            }
            Console.WriteLine(num1);
            int num2 = 1; // 공식에서 분모의 (n-m)!
            for(int i = 1;i <= balls-share; i++)
            {
                num2 *= i;
            }
            Console.WriteLine(num2);
            int num3 = 1; // 공식에서 분모의 m!
            for( int i = 1; i <= share; i++)
            {
                num3 *= i;
            }
            Console.WriteLine(num3);
            int result = num1 / (num2 * num3);
            float console = num1 / (num2 * num3);

            Console.WriteLine(result);
            Console.WriteLine(console);

            return result;
            */

            int num1 = 1;
            for (int i = balls; i >= 1; i--)
            {
                if (i == share)
                {
                    break;
                }
                num1 *= i;
            }
            Console.WriteLine(num1);
            int num2 = 1;
            for (int i = balls - share; i >= 1; i--)
            {
                num2 *= i;
            }
            Console.WriteLine(num2);

            int result = num1 / num2;
            Console.WriteLine(result);
        }

        /// <summary>
        /// 제목 : 캐릭터의 좌표
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120861
        /// 문제 : 머쓱이는 RPG게임을 하고 있습니다. 게임에는 up, down, left, right 방향키가 있으며 각 키를 누르면 
        ///        위, 아래, 왼쪽, 오른쪽으로 한 칸씩 이동합니다. 
        ///        예를 들어 [0,0]에서 up을 누른다면 캐릭터의 좌표는 [0, 1], down을 누른다면 [0, -1], 
        ///        left를 누른다면 [-1, 0], right를 누른다면 [1, 0]입니다. 
        ///        머쓱이가 입력한 방향키의 배열 keyinput와 맵의 크기 board이 매개변수로 주어집니다. 
        ///        캐릭터는 항상 [0,0]에서 시작할 때 키 입력이 모두 끝난 뒤에 
        ///        캐릭터의 좌표 [x, y]를 return하도록 solution 함수를 완성해주세요. 
        ///        [0, 0] 은 board의 정 중앙에 위치합니다.
        ///        예를 들어 board의 가로 크기가 9라면 캐릭터는 왼쪽으로 최대 [-4, 0] 까지 오른쪽으로 최대[4, 0] 까지 이동할 수 있습니다.
        /// 예시 : [ "left", "right", "up", "right", "right", [ 11, 11 ] ] => [ 2, 1 ] 
        ///      / [ "down", "down", "down", "down", "down", [ 7, 9 ] ] => [ 0, -4 ]
        /// </summary>
        /// 케이스 8번 오류
        /// [ ["right", "right", "right", "right", "right", "left"] [9, 5] ] => [ 3, 0 ]
        /// Why? 4, 0 이 결과 값이 아닌가...?
        public static void MoveVector(string[] keyinput, int[] board)
        {
            // 캐릭터의 기본 좌표값
            int x = 0; // 오른쪽 +1 / 왼쪽 -1
            int y = 0; // 위쪽 +1 / 아랫쪽 -1
            foreach (string key in keyinput)
            {
                switch (key)
                {
                    case "up":
                        y += 1;
                        break;
                    case "down":
                        y -= 1;
                        break;
                    case "left":
                        x -= 1;
                        break;
                    case "right":
                        x += 1;
                        break;
                }
            }
            Console.WriteLine($"{x} : {y}");
            int sizeX = board[0] / 2; // x의 사이즈
            int sizeY = board[1] / 2; // y의 사이즈
            Console.WriteLine($"{sizeX} : {sizeY}");

            if(x < sizeX * -1)
            {
                x = Math.Max(x, sizeX * -1);
            }
            else if(x > sizeX)
            {
                x = Math.Min(x, sizeX);
            }
            if(y < sizeY * -1)
            {
                y = Math.Max(y, sizeY * -1);
            }
            else if(y > sizeY)
            {
                y = Math.Min(y, sizeY);
            }
            Console.WriteLine($"{x} : {y}");

            int[] answer = new int[2];
            answer[0] = x;
            answer[1] = y;

        }

        /// <summary>
        /// 제목 : 외계어 사전
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120869
        /// 문제 : PROGRAMMERS-962 행성에 불시착한 우주비행사 머쓱이는 외계행성의 언어를 공부하려고 합니다.
        ///        알파벳이 담긴 배열 spell과 외계어 사전 dic이 매개변수로 주어집니다. 
        ///        spell에 담긴 알파벳을 한번씩만 모두 사용한 단어가 dic에 존재한다면 1, 
        ///        존재하지 않는다면 2를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ ["p", "o", "s"], ["sod", "eocd", "qixm", "adio", "soo"] ] => [ 2 ]
        ///      / [ ["z", "d", "x"], ["def", "dww", "dzx", "loveaw"] ] => [ 1 ]
        ///      / [ ["s", "o", "m", "d"], ["moos", "dzx", "smm", "sunmmo", "som"] ] => [ 2 ]
        /// </summary>
        /// 
        public static void AliensDic(string[] spell, string[] dic)
        {
            
        }
        /// <summary>
        /// 제목 : 종이 자르기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120922
        /// 문제 : 머쓱이는 큰 종이를 1 x 1 크기로 자르려고 합니다. 
        ///        예를 들어 2 x 2 크기의 종이를 1 x 1 크기로 자르려면 최소 가위질 세 번이 필요합니다.
        ///        정수 M, N이 매개변수로 주어질 때, M x N 크기의 종이를 최소로 가위질 해야하는 횟수를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 2, 2 ] => [ 3 ] / [ 2, 5 ] => [ 9 ] / [ 1, 1 ] => [ 0 ]
        /// </summary>
        /// 
        public int CuttingPaper(int m, int n)
        {
            int result = (m - 1) + ((n - 1) * m);

            return result;
        }

        /// <summary>
        /// 제목 : 직사각형 넓이 구하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120860
        /// 문제 : 2차원 좌표 평면에 변이 축과 평행한 직사각형이 있습니다. 
        ///        직사각형 네 꼭짓점의 좌표 [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]가 담겨있는 배열 dots가 매개변수로 주어질 때, 
        ///        직사각형의 넓이를 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ [1, 1], [2, 1], [2, 2], [1, 2] ] => [ 1 ] / [ [-1, -1], [1, 1], [1, -1], [-1, 1] ] => [ 4 ]
        /// </summary>
        /// 
        public static void SquareArea(int[,] dots)
        {
            for(int j = 1; j <= dots.GetLength(0)-1; j++)
            {

            }

            for (int j = 0; j < dots.GetLength(0); j++)
            {
                for (int i = 0; i < dots.GetLength(1); i++)
                {
                    Console.Write(dots[j, i]);Console.Write(", ");
                }
                Console.WriteLine();
            }
            /*for(int i = 0; i < dots.GetLength(1); i++)
            {
                for(int j = 0; j < dots.GetLength(0); j++)
                {
                    Console.WriteLine(dots[j, i]);
                }
            }*/
        }
        /// <summary>
        /// 제목 : 로그인 성공?
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120883
        /// 문제 : 머쓱이는 프로그래머스에 로그인하려고 합니다. 머쓱이가 입력한 아이디와 패스워드가 담긴 배열 id_pw와 
        ///        회원들의 정보가 담긴 2차원 배열 db가 주어질 때, 다음과 같이 로그인 성공, 실패에 따른 메시지를 
        ///        return하도록 solution 함수를 완성해주세요. 
        ///        아이디와 비밀번호가 모두 일치하는 회원정보가 있으면 "login"을 return합니다.
        ///        로그인이 실패했을 때 아이디가 일치하는 회원이 없다면 “fail”를, 
        ///        아이디는 일치하지만 비밀번호가 일치하는 회원이 없다면 “wrong pw”를 return 합니다.
        /// 예시 : [ "meosseugi", "1234" / ["rardss", "123"], ["yyoom", "1234"], ["meosseugi", "1234"] ] => [ "login" ]
        ///      / [ "programmer01", "15789" / ["programmer02", "111111"], ["programmer00", "134"], ["programmer01", "1145"] ] => [ "wrong pw" ]
        ///      / [ "rabbit04", "98761" / ["jaja11", "98761"], ["krong0313", "29440"], ["rabbit00", "111333"] ] => [ "fail" ]
        /// </summary>
        /// 
        /// <summary>
        /// 제목 : 치킨 쿠폰
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120884
        /// 문제 : 프로그래머스 치킨은 치킨을 시켜먹으면 한 마리당 쿠폰을 한 장 발급합니다.
        ///        쿠폰을 열 장 모으면 치킨을 한 마리 서비스로 받을 수 있고, 서비스 치킨에도 쿠폰이 발급됩니다. 
        ///        시켜먹은 치킨의 수 chicken이 매개변수로 주어질 때 받을 수 있는 최대 서비스 치킨의 수를 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 100 ] => [ 11 ] / [ 1081 ] => [ 120 ]
        /// </summary>
        /// 1차 : 2,4,5,8,10 실패
        public static int ChickenCupon(int chicken)
        {
            int count = 0;
            int sum = 0;
            while (chicken > 10)
            {
                chicken /= 10;
                sum += chicken;
                count++;
            }
            sum += count;

            Console.WriteLine(sum);
            return sum;
        }


    }
}
