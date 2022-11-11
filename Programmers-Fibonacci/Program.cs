using System;

namespace Programmers_Fibonacci
{
    class Program
    {
        public static int Fibo(int n)
        {
            int firstIdx = 1;
            int secondIdx = 1;
            int resultIdx = 0;

            if (n <= 2) return 1;
            for (int i = 3; i <= n; i++)
            {
                resultIdx = (firstIdx + secondIdx) % 1234567;
                firstIdx = secondIdx;
                secondIdx = resultIdx;
            }
            return resultIdx;
        }

        public int solution(int n)
        {
            int answer = 0;
            int fibo_n = Fibo(n);

            answer = fibo_n;

            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Fibo(3));
            Console.WriteLine("{0}", Fibo(5));
        }
    }
}
