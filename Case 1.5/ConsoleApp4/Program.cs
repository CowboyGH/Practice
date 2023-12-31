﻿namespace ConsoleApp4;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.5\ConsoleApp4\numsTask4.txt";
        int max = int.MinValue;
        int sum = 0;

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(' ');

            for (int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                if (max < number)
                {
                    max = number;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                if (max - number == 1)
                {
                    sum += number;
                }
            }
            
            Console.WriteLine($"Cумма элементов, отличающихся от максимального на 1 равна {sum}.");
        }
    }
}