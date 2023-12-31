﻿namespace ConsoleApp1;

public static class Program
{
    public static void Main()
    {
        const int N = 10;
        int[] nums = new int[N];
        Random rand = new Random();

        for (int i = 0; i < N; i++)
        {
            nums[i] = rand.Next(0, 10000);
        }

        int numsMin = nums.Min();
        int indexMin = Array.IndexOf(nums, numsMin);
        Console.WriteLine($"Индекс минимального элемента равен -> {indexMin}");
    }
}