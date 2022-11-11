using System;
using System.Collections.Generic;

namespace Programmers_year2016
{
    class Program
    {
        public static string solution(int a, int b)
        {
            string answer = "";
            Dictionary<int, int> month = new Dictionary<int, int>();
            int day = 0;

            month.Add(1, 31);
            month.Add(2, 29);
            month.Add(3, 31);
            month.Add(4, 30);
            month.Add(5, 31);
            month.Add(6, 30);
            month.Add(7, 31);
            month.Add(8, 31);
            month.Add(9, 30);
            month.Add(10, 31);
            month.Add(11, 30);
            month.Add(12, 31);

            for (int i = 1; i < a; i++)
            {
                day += month[i];
            }
            day += b;

            switch (day % 7)
            {
                case 0:
                    answer = "THU";
                    break;
                case 1:
                    answer = "FRI";
                    break;
                case 2:
                    answer = "SAT";
                    break;
                case 3:
                    answer = "SUN";
                    break;
                case 4:
                    answer = "MON";
                    break;
                case 5:
                    answer = "TUE";
                    break;
                case 6:
                    answer = "WED";
                    break;
                case 7:
                    answer = "THU";
                    break;
            }

            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(5,24));
        }
    }
}
