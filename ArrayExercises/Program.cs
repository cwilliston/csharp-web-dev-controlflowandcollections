﻿using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 5, 8 };

            foreach (int i in array) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
