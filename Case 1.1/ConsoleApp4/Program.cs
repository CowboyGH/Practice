namespace ConsoleApp4;

public static class Program
{
    public static void Main()
    {
        Console.Write("Введите начало диапазона -> ");
        int start = 0;
        start = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите конец диапазона -> ");
        int end = 0;
        end = Convert.ToInt32(Console.ReadLine());
        
        int[] numbers = Massive(start, end);
        
        foreach(int i in numbers)
        {
            Console.Write($"{i} ");
        }
    }
    
    static int[] Massive(int start, int end)
    {
        int n = 0;
        Console.Write("Введите размерность массива -> ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];
        Random rand = new Random();
             
        for (int i = 0; i < n; i++)
        {
            nums[i] = rand.Next(start, end);
        }
        
        return nums;
    }
}