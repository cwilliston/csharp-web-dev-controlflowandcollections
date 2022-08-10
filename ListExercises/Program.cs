using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            public static List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            static int sumEven(List<int> numbers);
        }

        private static int sumEven(List<int> arr)
        {
            int total = 0;
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    total += num;
                }
            }
            return total;
        }
    }
}
