using System;

namespace Programmers_MaximumNum
{
    class Program
    {
        public static string solution(int[] numbers)
        {
            string answer = "";
            Array.Sort(numbers, (x, y) => string.Compare(y.ToString() + x.ToString(), x.ToString() + y.ToString()));

            answer = String.Join("", numbers);

            int cnt = 0;
            foreach (var i in answer)
            {
                if (i == '0') cnt++;
            }

            if (cnt == answer.Length) return "0";
            else return answer;
        }
        static void Main(string[] args)
        {
            int[] a = { 6, 10, 2 };
            int[] b = { 3, 30, 34, 5, 9 };
            Console.WriteLine(solution(a));
            Console.WriteLine(solution(b));
        }
    }
}
