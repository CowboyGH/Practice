﻿namespace ConsoleApp6;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int size = rand.Next(1, 10);
        
        double[] nums = new double[size];

        for (int i = 0; i < size; i++)
        {
            nums[i] = rand.NextDouble() * (20 + 20) - 20;
        }
        
        List<double> positiveNums = new List<double>();
        List<double> negativeNums = new List<double>();

        foreach (var num in nums)
        {
            if (num > 0)
            {
                positiveNums.Add(num);
            }
            else
            {
                negativeNums.Add(num);
            }
        }
        
        Console.WriteLine("Первоначальный массив");
        
        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine("\nМассив положительных чисел");
        
        foreach (var num in positiveNums)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine("\nМассив отрицательных чисел");
        
        foreach (var num in negativeNums)
        {
            Console.Write(num + " ");
        }
    }
}