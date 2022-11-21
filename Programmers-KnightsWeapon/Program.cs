using System;

namespace Programmers_KnightsWeapon
{
    class Program
    {
        public static int weights(int n, int limit)
        {
            int cnt = 0;
            int i;
            for (i = 1; i * i < n; i++)
            {
                if (n % i == 0) cnt += 2;
            }
            if (i * i == n) cnt++;

            if (cnt > limit) return 0;
            else return cnt;
        }

        public static int solution(int number, int limit, int power)
        {
            int answer = 0;

            for (int i = 1; i <= number; i++)
            {
                int temp = weights(i, limit);
                if (temp != 0) answer += temp;
                else answer += power;
            }

            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", solution(5, 3, 2));
            Console.WriteLine("{0}", solution(10, 3, 2));
        }
    }
}
