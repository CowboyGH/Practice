﻿namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.6\ConsoleApp1\numsTask1.txt";

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] words = str.Split(' ');

            foreach (var word in words)
            {
                if (word.Length % 2 != 0)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}