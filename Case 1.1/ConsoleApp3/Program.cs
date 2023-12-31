﻿namespace ConsoleApp3;

public static class Program
{
    public static void Main()
    {
        int n = 0;
        int countMax = 0;
        int countMin = 0;
        int sMin = 10000;
        int sMax = -1;
        Console.Write("Введите размерность массива -> ");
        n = Convert.ToInt32(Console.ReadLine());
        string?[] s = new string?[n];
        Console.WriteLine($"Введите {n} строк: ");
        
        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
            if (s[i] == "")
            {
                break;
            }
            
            if (sMax < s[i].Length)
            {
                sMax = s[i].Length;
                countMax = i;
            }

            if (sMin > s[i].Length)
            {
                sMin = s[i].Length;
                countMin = i;
            }
        }

        Console.WriteLine($"Самый короткий элемент списка: {s[countMin]}");
        Console.WriteLine($"Самый длинный элемент списка: {s[countMax]}");
    }
}