using System;
using System.Linq;
using System.Collections.Generic;

namespace Programmes_ParkingFee
{
    class Program
    {
        public static int GetTimeGap(string t1, string t2 = "23:59")
        {
            int inTime = ConvertToMinute(t1);
            int outTime = ConvertToMinute(t2);
            return outTime - inTime;
        }

        public static int ConvertToMinute(string t)
        {
            string[] time_temp = t.Split(':');
            return Convert.ToInt32(time_temp[0]) * 60 + Convert.ToInt32(time_temp[1]);
        }

        public static int FeeCalc(int time, int[] fees)
        {
            int fee = fees[1];
            time -= fees[0];
            if (time > 0)
            {
                int temp = (int)Math.Ceiling((double)time / fees[2]);
                fee += fees[3] * temp;
            }
            return fee;
        }

        public static int[] solution(int[] fees, string[] records)
        {
            int[] answer = new int[] { };
            Dictionary<string, string> Record = new Dictionary<string, string>();
            Dictionary<string, int> Fee = new Dictionary<string, int>();

            for (int i = 0; i < records.Length; i++)
            {
                string[] temp = records[i].Split(' ');
                if (temp[2] == "IN")
                {
                    Record.Add(temp[1], temp[0]);
                }
                else
                {
                    if (!Fee.ContainsKey(temp[1]))
                    {
                        Fee.Add(temp[1], GetTimeGap(Record[temp[1]], temp[0]));
                        Record.Remove(temp[1]);
                    }
                    else
                    {
                        Fee[temp[1]] += GetTimeGap(Record[temp[1]], temp[0]);
                        Record.Remove(temp[1]);
                    }
                }
            }

            foreach (KeyValuePair<string, string> keys in Record)
            {
                if (!Fee.ContainsKey(keys.Key))
                {
                    Fee.Add(keys.Key, GetTimeGap(keys.Value));
                }
                else
                {
                    Fee[keys.Key] += GetTimeGap(keys.Value);
                }
            }
            List<string> list = Fee.Keys.ToList();
            list.Sort();
            answer = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                answer[i] = FeeCalc(Fee[list[i]], fees);
            }

            return answer;
        }
        static void Main(string[] args)
        {
            int[] a = { 180, 5000, 10, 600 };
            string[] record = { "05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT" };
            int[] answer = solution(a, record);
            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine("{0}",answer[i]);
            }
        }
    }
}
