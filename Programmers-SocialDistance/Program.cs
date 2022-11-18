using System;

namespace Programmers_SocialDistance
{
    class Program
    {
        public static int socialDistance(string[] room)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (room[i][j] == 'P')
                    { //왼쪽으로는 가지 않아도 된다. 이미 검사했으니까.
                        if (j + 1 <= 4)
                        { //오른쪽 체크
                            if (room[i][j + 1] == 'P') { return 0; }
                            if (room[i][j + 1] == 'O')
                            {
                                if (j + 2 <= 4 && room[i][j + 2] == 'P') return 0;
                                if (i + 1 <= 4 && room[i + 1][j + 1] == 'P') return 0;
                                if (i - 1 >= 0 && room[i - 1][j + 1] == 'P') return 0;
                            }
                        }
                        if (i - 1 >= 0)
                        { //위쪽 체크
                            if (room[i - 1][j] == 'P') { return 0; }
                            if (room[i - 1][j] == 'O')
                            {
                                if (i - 2 >= 0 && room[i - 2][j] == 'P') return 0;
                                if (j + 1 <= 4 && room[i - 1][j + 1] == 'P') return 0;
                            }
                        }
                        if (i + 1 <= 4)
                        { //아래쪽 체크
                            if (room[i + 1][j] == 'P') { return 0; }
                            if (room[i + 1][j] == 'O')
                            {
                                if (i + 2 <= 4 && room[i + 2][j] == 'P') return 0;
                                if (j + 1 <= 4 && room[i + 1][j + 1] == 'P') return 0;
                            }
                        }//대각선도 줄일 수 있지 않을까? 했는데 불가능할듯. 관점별로 검사 필요.
                    }
                }
            }
            return 1;
        }

        public static int[] solution(string[,] places)
        {
            int[] answer = new int[5];
            for (int i = 0; i < 5; i++)
            {
                string[] temp = new string[5];
                for (int j = 0; j < 5; j++)
                {
                    temp[j] = places[i, j];
                }
                answer[i] = socialDistance(temp);
            }
            return answer;
        }
        static void Main(string[] args)
        {
            string[,] test = { { "POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP" },
                               { "POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP" },
                               { "PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX" },
                               { "OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO" },
                               { "PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP" } };

            int[] result = new int[5];
            result = solution(test);
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("{0}", result[i]);
            }
        }
    }
}
