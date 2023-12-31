﻿namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.5\ConsoleApp2\numsTask2.txt";

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] strNums = str.Split(';');
            float[] nums = new float[strNums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = float.Parse(strNums[i]);
            }
            
            stream.Close();
            
            File.WriteAllText(inputPath, string.Empty);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        float temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            
            string entry = String.Empty;

            for (int i = 0; i < nums.Length; i++)
            {
                entry += i != nums.Length - 1 ? $"{nums[i]};" : $"{nums[i]}";
            }
            
            using (StreamWriter writer = new StreamWriter(inputPath))
            {
                writer.WriteLine(entry);
            }
        }
    }
}