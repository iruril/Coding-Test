using System;

namespace Programmers_LCMofNumbers
{
    class Program
    {
        public static int solution(int[] arr)
        {
            int answer = 0;
            int len = arr.Length;
            int max = arr[len - 1];
            int cnt = 0;

            for (int i = 1; ; i++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    if ((max * i) % arr[j] == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt == len - 1)
                {
                    answer = max * i;
                    return answer;
                }
                cnt = 0;
            }

            return answer;
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 6, 8, 14 };
            Console.WriteLine("{0}",solution(a));
        }
    }
}
