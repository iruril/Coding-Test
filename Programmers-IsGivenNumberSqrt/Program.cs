using System;

namespace Programmers_IsGivenNumberSqrt
{
    class Program
    {
        static public long solution(long n)
        {
            long answer = 0;
            var sqr = Math.Sqrt(n);
            answer = (long)sqr;
            if (sqr % 1 != 0)
            {
                return -1;
            }
            answer = (long)Math.Pow(answer + 1, 2);

            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}",solution(121));
            Console.WriteLine("{0}",solution(3));
        }
    }
}
