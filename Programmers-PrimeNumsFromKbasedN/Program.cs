using System;

namespace Programmers_PrimeNumsFromKbasedN
{
    class Program
    {
        public static string ConvertToBased(int n, int k)
        {
            string str = "";
            int a = n;
            while (a > k)
            {
                str += (a % k).ToString();
                a = a / k;
            }
            str += a.ToString();
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr); ;
        }

        public static bool isPrime(long n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static int solution(int n, int k)
        {
            int answer = -1;
            int count = 0;
            string number = ConvertToBased(n, k);
            string[] numbers = number.Split('0', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (isPrime(Convert.ToInt64(numbers[i])))
                {
                    count++;
                }
            }
            answer = count;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", solution(437674, 3));
            Console.WriteLine("{0}", solution(110011, 10));
        }
    }
}
