﻿namespace ConsoleApp4;

class Program
{
    const int Months = 12;
    const int Days = 30;
    
    
    static int[] avgTemp(int[,] yearTemp)
    {
        int[] avgArray = new int[Months];
        
        for (int i = 0; i < Months; i++)
        {
            int sum = 0;

            for (int j = 0; j < Days; j++)
            {
                sum += yearTemp[i, j];
            }

            avgArray[i] = sum / Days;
        }
        
        Array.Sort(avgArray);

        return avgArray;
    }
    
    
    static void Main()
    {
        int[,] yearTemp = new int[Months, Days];
        Random rand = new Random();

        for (int i = 0; i < Months; i++)
        {
            for (int j = 0; j < Days; j++)
            {
                yearTemp[i, j] = rand.Next(15, 40);
            }
        }
        
        int[] avgArray = avgTemp(yearTemp);
        
        for (int i = 0; i < Months; i++)
        {
            Console.Write($"{avgArray[i], 5}");
        }
    }
}