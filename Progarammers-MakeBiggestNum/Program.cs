using System;
using System.Text;

namespace Progarammers_MakeBiggestNum
{
    class Program
    {
        public static string solution(string number, int k)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();
            int n = number.Length - k;

            int start = 0; //최초 검사 시작 위치, 검사가 끝난 해당 위치 기준으로 + maxIdx됨.
            int end = k; //최초 검사 종료 위치, 검사가 끝날 때 마다  하나씩 늘어남.

            char max = '0'; //각 검사 별 최댓값
            int maxIdx = 0; //최댓값의 인덱스

            for (int i = 0; i < n; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    if (max < number[j])
                    {
                        max = number[j];
                        maxIdx = j;
                    }
                }
                sb.Append(max);
                start = maxIdx + 1;
                end++;
                max = '0';
            }
            answer = sb.ToString();
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution("1924", 2));
            Console.WriteLine(solution("1231234", 3));
            Console.WriteLine(solution("4177252841", 4));
        }
    }
}
