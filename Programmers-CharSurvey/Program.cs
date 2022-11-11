using System;

namespace Programmers_CharSurvey
{
    class Program
    {
        static string solution(string[] survey, int[] choices)
        {
            string answer = "";
            int[] rt = new int[] { 0, 0 };
            int[] fc = new int[] { 0, 0 };
            int[] mj = new int[] { 0, 0 };
            int[] an = new int[] { 0, 0 };

            for (int i = 0; i < choices.Length; i++)
            {
                if ((choices[i] - 4) < 0)
                {
                    switch (survey[i])
                    {
                        case "RT":
                            rt[0] -= choices[i] - 4;
                            break;
                        case "TR":
                            rt[1] -= choices[i] - 4;
                            break;
                        case "FC":
                            fc[0] -= choices[i] - 4;
                            break;
                        case "CF":
                            fc[1] -= choices[i] - 4;
                            break;
                        case "MJ":
                            mj[0] -= choices[i] - 4;
                            break;
                        case "JM":
                            mj[1] -= choices[i] - 4;
                            break;
                        case "AN":
                            an[0] -= choices[i] - 4;
                            break;
                        case "NA":
                            an[1] -= choices[i] - 4;
                            break;
                    }
                }
                else if ((choices[i] - 4) > 0)
                {
                    switch (survey[i])
                    {
                        case "RT":
                            rt[1] += choices[i] - 4;
                            break;
                        case "TR":
                            rt[0] += choices[i] - 4;
                            break;
                        case "FC":
                            fc[1] += choices[i] - 4;
                            break;
                        case "CF":
                            fc[0] += choices[i] - 4;
                            break;
                        case "MJ":
                            mj[1] += choices[i] - 4;
                            break;
                        case "JM":
                            mj[0] += choices[i] - 4;
                            break;
                        case "AN":
                            an[1] += choices[i] - 4;
                            break;
                        case "NA":
                            an[0] += choices[i] - 4;
                            break;
                    }
                }
            }
            if (rt[0] < rt[1]) answer += "T"; else answer += "R";
            if (fc[0] > fc[1]) answer += "F"; else answer += "C";
            if (mj[0] > mj[1]) answer += "M"; else answer += "J";
            if (an[0] < an[1]) answer += "N"; else answer += "A";

            return answer;
        }

        static void Main(string[] args)
        {
            string[] exam = new string[] { "AN", "CF", "MJ", "RT", "NA" };
            int[] choiceExam = new int[] { 5, 3, 2, 7, 5 };
            string returnVal = "";
            returnVal = solution(exam, choiceExam);

            Console.WriteLine(returnVal);
        }
    }
}
