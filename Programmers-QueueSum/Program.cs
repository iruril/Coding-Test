using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers_QueueSum
{
    class Program
    {
        public static int solution(int[] queue1, int[] queue2)
        {
            int answer = 0;
            Queue<long> q1 = new Queue<long>();
            Queue<long> q2 = new Queue<long>();
            for (int i = 0; i < queue1.Length; i++)
            {
                q1.Enqueue(Convert.ToInt64(queue1[i]));
                q2.Enqueue(Convert.ToInt64(queue2[i]));
            }

            long sum1 = q1.Sum();
            long sum2 = q2.Sum();

            if ((sum1 + sum2) % 2 == 1)
            {
                return -1;
            }

            for (int i = 0; i < queue1.Length * 4; i++)
            {
                if (sum1 < sum2)
                {
                    sum1 += q2.Peek();
                    sum2 -= q2.Peek();
                    q1.Enqueue(q2.Dequeue());
                    answer++;
                }
                else if (sum1 > sum2)
                {
                    sum1 -= q1.Peek();
                    sum2 += q1.Peek();
                    q2.Enqueue(q1.Dequeue());
                    answer++;
                }
                else
                {
                    return answer;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] q1 = { 1, 2, 1, 2 };
            int[] q2 = { 1, 10, 1, 2 };
            Console.WriteLine("{0}", solution(q1, q2));
        }
    }
}
