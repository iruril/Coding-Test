using System;

namespace Programmers_Words_and_Numbers
{
    class Program
    {
        public static int solution(string s)
        {
            int answer = 0;
            string answerStr = s;

            answerStr = answerStr.Replace("zero", "0");
            answerStr = answerStr.Replace("one", "1");
            answerStr = answerStr.Replace("two", "2");
            answerStr = answerStr.Replace("three", "3");
            answerStr = answerStr.Replace("four", "4");
            answerStr = answerStr.Replace("five", "5");
            answerStr = answerStr.Replace("six", "6");
            answerStr = answerStr.Replace("seven", "7");
            answerStr = answerStr.Replace("eight", "8");
            answerStr = answerStr.Replace("nine", "9");

            answer = int.Parse(answerStr);

            return answer;
        }
        static void Main(string[] args)
        {
            string s = "2three45sixseven";
            Console.WriteLine("{0}", solution(s));
        }
    }
}
