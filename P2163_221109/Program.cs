using System;

namespace P2163_221109
{
    class Program
    {
        static void Main()
        {
            String[] arr = Console.ReadLine().Split(' ');
            int N = int.Parse(arr[0]);
            int M = int.Parse(arr[1]);

            Console.WriteLine((N*M-1));
        }
    }
}
