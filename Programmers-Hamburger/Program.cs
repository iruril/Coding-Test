using System;
using System.Collections.Generic;
using System.Linq;

namespace Programmers_Hamburger
{
    class Program
    {
        public static int solution(int[] ingredient)
        {
            int answer = 0;
            List<int> ingredientStack = new List<int>();
            List<int> hamburger = new List<int>();
            hamburger.Add(1);
            hamburger.Add(2);
            hamburger.Add(3);
            hamburger.Add(1); //햄버거 완제품 예시

            for (int i = 0; i < ingredient.Length; i++)
            {
                ingredientStack.Add(ingredient[i]);
                if (ingredientStack.Count >= 4)
                {
                    List<int> temp = new List<int>();
                    temp.Add(ingredientStack[ingredientStack.Count - 4]);
                    temp.Add(ingredientStack[ingredientStack.Count - 3]);
                    temp.Add(ingredientStack[ingredientStack.Count - 2]);
                    temp.Add(ingredientStack[ingredientStack.Count - 1]);
                    if (temp.SequenceEqual(hamburger))
                    {
                        ingredientStack.RemoveAt(ingredientStack.Count - 1);
                        ingredientStack.RemoveAt(ingredientStack.Count - 1);
                        ingredientStack.RemoveAt(ingredientStack.Count - 1);
                        ingredientStack.RemoveAt(ingredientStack.Count - 1);
                        answer++;
                    }
                }
            }

            return answer;
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 1, 2, 3, 1, 2, 3, 1 };
            int[] b = { 1, 3, 2, 1, 2, 1, 3, 1, 2 };
            Console.WriteLine("{0}", solution(a));
            Console.WriteLine("{0}", solution(b));
        }
    }
}
