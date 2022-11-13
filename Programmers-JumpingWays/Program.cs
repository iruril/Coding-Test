using System;

namespace Programmers_JumpingWays
{
    class Program
    {
        //재귀로 하니, 역시나 시간복잡도 O(2^n)의 우람한 호출량을 버티질 못한다.
        public static long Function(int n)
        { //항상 성립하는 규칙이 있었음. 바로 F(n) = F(n-1) + F(n-2). 피보나치 수열??
            long a = 1; //n==1일때
            long b = 2; //n==2일때
            long c = 0;
            if (n == 1) return a;
            else if (n == 2) return b;

            for (int i = 3; i <= n; i++)
            {
                c = (a + b) % 1234567;
                a = b;
                b = c;
            }
            return c;
        }

        public static long solution(int n)
        { //원래는 홀, 짝으로 계속 분리해서 1이 최소 몇개 들어가는지 판별하려 했으나... 그 이후 검사 방법이 말도 안됨.
            long answer = 0;
            answer = Function(n);
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", solution(1));
            Console.WriteLine("{0}", solution(2));
            Console.WriteLine("{0}", solution(3));
            Console.WriteLine("{0}", solution(4));
            Console.WriteLine("{0}", solution(5));
        }
    }
}
