﻿namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        const int N = 100;
        int num = 3;
        int[] nums = new int[N];

        for (int i = 0; i < N; i++)
        {
            nums[i] = N - i * num;
        }
    }
}