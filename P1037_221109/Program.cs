using System;

namespace P1037_221109
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());

            String[] val = Console.ReadLine().Split();
            int[] array = new int[A];

            for (int i = 0; i < A; i++)
            {
                array[i] = int.Parse(val[i]);
            }
            Array.Sort(array);

            if(A == 1)
            {
                Console.WriteLine(array[0]* array[0]);
            }
            else
            {
                Console.WriteLine(array[0] * array[A-1]);
            }
        }
    }
}
