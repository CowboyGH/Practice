﻿namespace ConsoleApp5;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.5\ConsoleApp5\numsTask5.txt";
        int min = int.MaxValue;
        int max = int.MinValue;
        float average = 0;
        int count = 0;

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(' ');
            int minIndex = 0;
            int maxIndex = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                if (min > number)
                {
                    min = number;
                    minIndex = i;
                }

                if (max < number)
                {
                    max = number;
                    maxIndex = i;
                }
            }

            if (minIndex < maxIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    int number = Convert.ToInt32(nums[i]);
                    average += number;
                    count++;
                }
                
                average /= count;
            }
            else
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    int number = Convert.ToInt32(nums[i]);
                    average += number;
                    count++;
                }
                
                average /= count;
            }
            
            Console.WriteLine($"Среднее арифметическое элементов, расположенных между {min} и {max}, равно {average}.");
        }
    }
}