﻿namespace ConsoleApp5;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите строку слов:");
        string? str = Console.ReadLine();
        int spaceCount = 0;
        
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' && str[i] != '\0')
            {
                spaceCount++;
            }
        }
        
        str = "Start " + str + " End";
        Console.WriteLine($"В строке содержится {++spaceCount} слов(а).");
    }
}