using System;
using System.Collections.Generic;
using System.Linq; //중복된 데이터 삭제용

namespace Programmers_ReportManage
{
    class Program
    {
        static public int[] solution(string[] id_list, string[] report, int k)
        {
            Dictionary<string, int> reportedInfo = new Dictionary<string, int>(); //신고 당한 횟수
            Dictionary<string, List<string>> reportInfo = new Dictionary<string, List<string>>(); //신고한 사람
            List<int> answerList = new List<int>();
            int[] answer = new int[] { };

            report = report.Distinct().ToArray();

            for (int i = 0; i < report.Length; i++)
            {
                string[] reportSplit = report[i].Split(' ');
                string reportedID = reportSplit[1];
                string reportID = reportSplit[0];

                if (reportInfo.ContainsKey(reportID))
                {
                    reportInfo[reportID].Add(reportedID);
                }
                else
                {
                    reportInfo.Add(reportID, new List<string> { reportedID }); //최초 추가시
                }

                if (reportedInfo.ContainsKey(reportedID))
                {
                    reportedInfo[reportedID]++;
                }
                else
                {
                    reportedInfo.Add(reportedID, 1); //최초 추가시
                }
            }

            for (int i = 0; i < id_list.Length; i++)
            {
                int count = 0;
                if (reportInfo.ContainsKey(id_list[i]))
                {
                    for (int j = 0; j < reportInfo[id_list[i]].Count; j++)
                    {
                        if (reportedInfo.ContainsKey(reportInfo[id_list[i]][j]))
                        {
                            if (reportedInfo[reportInfo[id_list[i]][j]] >= k)
                            {
                                count++;
                            }
                        }
                    }
                }
                answerList.Add(count);
            }

            answer = answerList.ToArray();

            return answer;
        }

        static void Main(string[] args)
        {
            string[] id_list = { "muzi", "frodo", "apeach", "neo" };
            string[] report = { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k = 2;

            int[] answer = solution(id_list, report, k);

            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine("{0}",answer[i]);
            }
        }
    }
}
