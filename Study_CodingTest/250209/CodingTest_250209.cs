namespace Study_CodingTest._250209

{
    public class CodingTest_250209
    {
        /// <summary>
        /// 제목 : 모스부호(1)
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120838
        /// 문제 : 머쓱이는 친구에게 모스부호를 이용한 편지를 받았습니다. 
        ///        그냥은 읽을 수 없어 이를 해독하는 프로그램을 만들려고 합니다. 문자열 letter가 매개변수로 주어질 때, 
        ///        letter를 영어 소문자로 바꾼 문자열을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ ".... . .-.. .-.. ---" ] => [ "hello" ] / [ ".--. -.-- - .... --- -." ] => [ "python" ]
        /// </summary>
        /// 
        public string MorseCodeDecoding(string letter)
        {
            Dictionary<string, char> morseDic = new Dictionary<string, char>(); // 모스부호 종류 저장
            morseDic.Add(".-", 'a'); morseDic.Add("-...", 'b'); morseDic.Add("-.-.", 'c'); morseDic.Add("-..", 'd'); morseDic.Add(".", 'e');
            morseDic.Add("..-.", 'f'); morseDic.Add("--.", 'g'); morseDic.Add("....", 'h'); morseDic.Add("..", 'i'); morseDic.Add(".---", 'j');
            morseDic.Add("-.-", 'k'); morseDic.Add(".-..", 'l'); morseDic.Add("--", 'm'); morseDic.Add("-.", 'n'); morseDic.Add("---", 'o');
            morseDic.Add(".--.", 'p'); morseDic.Add("--.-", 'q'); morseDic.Add(".-.", 'r'); morseDic.Add("...", 's'); morseDic.Add("-", 't');
            morseDic.Add("..-", 'u'); morseDic.Add("...-", 'v'); morseDic.Add(".--", 'w'); morseDic.Add("-..-", 'x'); morseDic.Add("-.--", 'y');
            morseDic.Add("--..", 'z');

            string[] morseSpell = letter.Split(' '); // 공백으로 문자를 나누어 스펠링 모스부호 별로 저장
            char[] spelling = new char[morseSpell.Length];
            for (int i = 0; i < morseSpell.Length; i++)
            {
                spelling[i] = morseDic[morseSpell[i]]; // morseDic에서 키에 알맞은 값을 저장
            }
            string answer = new string(spelling); // char 배열을 string으로 변환

            return answer;
        }

        /// <summary>
        /// 제목 : k의 개수
        /// URL :  https://school.programmers.co.kr/learn/courses/30/lessons/120887
        /// 문제 : 1부터 13까지의 수에서, 1은 1, 10, 11, 12, 13 이렇게 총 6번 등장합니다. 
        ///        정수 i, j, k가 매개변수로 주어질 때, i부터 j까지 k가 몇 번 등장하는지 return 하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 1, 13, 1 ] => [ 6 ] / [ 10, 50, 5 ] => [ 5 ] / [ 3, 10, 2 ] => [ 0 ]
        /// </summary>
        /// 
        public int CountK(int i, int j, int k)
        {
            int count = 0; // k의 개수
            for (int nowNum = i; nowNum <= j; nowNum++)
            {
                int temp = nowNum;
                while (temp > 0) // 현재의 숫자가 0보다 큰 경우 지속
                {
                    if (temp % 10 == k) // 일의 자리 숫자가 k와 같은경우
                    {
                        count++;
                    }
                    temp /= 10; // 비교 후 일의 자리 숫자 빼기
                }
            }

            return count;
        }

        /// <summary>
        /// 제목 : 중복된 문자 제거
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120888
        /// 문제 : 문자열 my_string이 매개변수로 주어집니다.
        ///        my_string에서 중복된 문자를 제거하고 하나의 문자만 남긴 문자열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ "people" ]=>[ "peol" ] / [ "We are the world" ]=>[ "We arthwold" ] /
        /// </summary>
        /// 
        public string OverlapString(string my_string)
        {
            List<char> words = new List<char>();
            foreach (char c in my_string)
            {
                words.Add(c);
            }
            words = words.Distinct().ToList(); // List에서 중복값 제거하기
            string answer = new string(words.ToArray());
            Console.WriteLine(answer);
            return answer;
        }

        /// <summary>
        /// 제목 : 한 번만 등장한 문자
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120896
        /// 문제 : 문자열 s가 매개변수로 주어집니다. s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 
        ///        문자열을 return 하도록 solution 함수를 완성해보세요. 한 번만 등장하는 문자가 없을 경우 빈 문자열을 return 합니다.
        /// 예시 : [ "abcabcadc" ]=>[ "d" ] / [ "abdc" ]=>[ "abcd" ] / [ "hello" ]=>[ "eho" ]
        /// </summary>
        /// 프로그래머스 에러 : Solution0.cs(32,46): error CS1525: Unexpected symbol `(', expecting `)', `,', or `identifier'
        public static string OneStirng(string s)
        {
            // 문자를 문자열 배열로 만들기
            char[] spells = s.ToCharArray();
            Array.Sort(spells); // 오름차순으로 정렬
            List<char> answer = new List<char>();
            int count = 0;

            // 이중 for문
            for (int i = 0; i < spells.Length; i++)
            {
                for (int j = 0; j < spells.Length; j++)
                {
                    if (spells[i] == spells[j])
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (count == 1)
                {
                    answer.Add(spells[i]);
                    count = 0;
                }
                else { count = 0; }
            }
            string result = new(answer.ToArray());
            Console.WriteLine(result);
            return result;
        }

        /// <summary>
        /// 제목 : 7의 개수
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120912
        /// 문제 : 머쓱이는 행운의 숫자 7을 가장 좋아합니다. 
        ///        정수 배열 array가 매개변수로 주어질 때, 7이 총 몇 개 있는지 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ 7, 77, 17 ] => [ 4 ] / [ 10, 29 ] => [ 0 ]
        /// </summary>
        /// 
        public int CountSeven(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                while (num > 0)
                {

                    if (num % 10 == 7)
                    {
                        count++;
                        num /= 10;
                    }
                    else
                    {
                        num /= 10;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// 제목 : 컨트롤 제트
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120853
        /// 문제 : 숫자와 "Z"가 공백으로 구분되어 담긴 문자열이 주어집니다. 
        ///        문자열에 있는 숫자를 차례대로 더하려고 합니다. 이 때 "Z"가 나오면 바로 전에 더했던 숫자를 뺀다는 뜻입니다.
        ///        숫자와 "Z"로 이루어진 문자열 s가 주어질 때, 머쓱이가 구한 값을 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ "1 2 Z 3" ] => [ 4 ] / [ "10 20 30 40" ] => [ 100 ] / [ "10 Z 20 Z 1" ] => [ 1 ] / [ "10 Z 20 Z" ] => [ 0 ]
        ///        [ "-1 -2 -3 Z" ] => [ -3 ]
        /// </summary>
        /// 
        public int CtrlZ(string s)
        {
            string[] spells = s.Split(' ').ToArray(); // 띄어쓰기로 분류
            int sum = 0; // 결과 합
            for (int i = 0; i < spells.Length; i++)
            {
                if (spells[i] == "Z") // Z문자를 발견한 경우
                {
                    int.TryParse(spells[i - 1], out int num);
                    sum -= num; // 이전 값을 빼기
                }
                else
                {
                    int.TryParse(spells[i], out int num);
                    sum += num;
                }
            }
            return sum;
        }

        /// <summary>
        /// 제목 : 소인수분해
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120852
        /// 문제 : 소인수분해란 어떤 수를 소수들의 곱으로 표현하는 것입니다. 
        ///        예를 들어 12를 소인수 분해하면 2 * 2 * 3 으로 나타낼 수 있습니다. 따라서 12의 소인수는 2와 3입니다. 
        ///        자연수 n이 매개변수로 주어질 때 n의 소인수를 오름차순으로 담은 배열을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ 12 ] => [ 2, 3 ] / [ 17 ] => [ 17 ] / [ 420 ] => [ 2, 3, 5, 7 ]
        /// </summary>
        /// 
        public int[] PrimeFactor(int n)
        {
            List<int> answer = new List<int>();
            while (n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (!answer.Contains(i))
                        {
                            n /= i;
                            answer.Add(i);
                            break;
                        }
                        else
                        {
                            n /= i;
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            int[] result = answer.ToArray();
            return result;
        }

        /// <summary>
        /// 제목 : 이진수 더하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120885
        /// 문제 : 이진수를 의미하는 두 개의 문자열 bin1과 bin2가 매개변수로 주어질 때, 
        ///        두 이진수의 합을 return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ "10" , "11" ] => [ "101" ] / [ "1001" , "1111" ] => [ "11000" ]
        /// </summary>
        /// 
        public string BinarySum(string bin1, string bin2)
        {
            char[] bin1Char = bin1.ToCharArray();
            char[] bin2Char = bin2.ToCharArray();
            int bin1Num = 0;
            int bin2Num = 0;

            // 이진수를 각각 10진수로 표현
            for (int i = bin1Char.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int num = 0;
                int.TryParse(bin1Char[j].ToString(), out num);
                bin1Num += (int)Math.Pow(2, i) * num; // Math.Pow 제곱근 연산
            }
            for (int i = bin2Char.Length - 1, j = 0; i >= 0; i--, j++)
            {
                int num = 0;
                int.TryParse(bin2Char[j].ToString(), out num);
                bin2Num += (int)Math.Pow(2, i) * num;
            }
            int sum = bin1Num + bin2Num; // 두 수의 합

            if (sum == 0) // 두 수의 합이 0인 경우 예외처리
            {
                return "0";
            }

            // 10진수를 2진수로 변환
            Stack<int> stack = new Stack<int>();
            while (sum > 0)
            {
                stack.Push(sum % 2);
                sum /= 2;
            }
            List<int> answer = new List<int>();
            for (int i = 0; stack.Count > 0; i++)
            {
                answer.Add(stack.Pop());
            }
            char[] arr = new char[answer.Count];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(answer[i].ToString());
            }

            string result = new string(arr);
            return result;
        }
        /// <summary>
        /// 제목 : 잘라서 배열로 저장하기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120913
        /// 문제 : 문자열 my_str과 n이 매개변수로 주어질 때, my_str을 길이 n씩 잘라서 저장한 배열을 
        ///        return하도록 solution 함수를 완성해주세요.
        /// 예시 : [ "abc1Addfggg4556b" , 6 ] => [ "abc1Ad", "dfggg4", "556b" ] / [ "abcdef123" , 3 ] => [ "abc", "def", "123" ]
        /// </summary>
        /// 
        public static void CutStringTo(string my_str, int n)
        {

            /*
             * Substring(a, b)을 사용하여 구현하고자 함
             * => 범위가 넘어서는 예외처리 방법을 잘 모르겠음
             */
            List<string> answer = new List<string>();
            int len = 0; // for문을 돌릴 길이

            // 나머지가 있는 경우 배열이 하나 더 생김
            if (my_str.Length % n == 0)
            {
                len = my_str.Length / n;
            }
            else if (my_str.Length % n != 0)
            {
                len = my_str.Length / n + 1;
            }

            for (int i = 0, count = 1; count <= len; i += n, count++)
            {
                // Substring(a,b) : a부터 b만큼 자르기
                string str = my_str.Substring(i, n);
                answer.Add(str);
            }

            foreach (string str in answer)
            {
                Console.WriteLine(str);
            }
        }
        /// <summary>
        /// 제목 : 공던지기
        /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/120843
        /// 문제 : 머쓱이는 친구들과 동그랗게 서서 공 던지기 게임을 하고 있습니다. 
        ///        공은 1번부터 던지며 오른쪽으로 한 명을 건너뛰고 그다음 사람에게만 던질 수 있습니다. 
        ///        친구들의 번호가 들어있는 정수 배열 numbers와 정수 K가 주어질 때,
        ///        k번째로 공을 던지는 사람의 번호는 무엇인지 return 하도록 solution 함수를 완성해보세요.
        /// 예시 : [ { 1, 2, 3, 4 }, 2 ] => [ 3 ] / [ { 1, 2, 3, 4, 5, 6 }, 5 ] => [ 3 ] / [ { 1, 2, 3 }, 3 ] => [ 2 ]
        /// </summary>
        /// 
        public int ThrowBall(int[] numbers, int k)
        {
            int answer = 0;
            for (int i = 0, count = 1; count <= k; count++)
            {
                if (i >= numbers.Length)
                {
                    i -= numbers.Length;
                }

                answer = numbers[i];
                i += 2;
            }

            return answer;
        }

    }
}
