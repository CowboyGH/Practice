﻿namespace ConsoleApp6;

class Program
{
    static void Main()
    {
        Console.Write("Введите число a -> "); 
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите число b -> ");
        float b = float.Parse(Console.ReadLine());
        
        if (a >= -2 && a <= 2 && 
            b >= -3 && b <= 2 &&
            a >= (b - 2) / 2.5 &&
            a <= (b - 2) / -2.5)
        {
            Console.Write($"Точка с кооординатами ({a}; {b}) принадлежит заштрихованной области.");
        }
        else
        {
            Console.Write("Заданная точка не принадлежит заштрихованной области.");
        }
    }
}