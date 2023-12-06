namespace ConsoleApp2;

public static class Program
{
    public static void Main()
    {
        int n = 0;
        int summ = 0;
        int total = 1;
        int count = 0;
        int average = 0;
        Console.Write("Введите размерность массива -> ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];
        Console.WriteLine($"Введите {n} чисел: ");
        
        for (int i = 0; i < n; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
            if (nums[i] == 0)
            {
                Console.WriteLine("Ввод окончен.");
                break;
            }

            summ += nums[i];
            total *= nums[i];
        }
        
        count = Array.IndexOf(nums, 0);
        average = summ / count;
        
        Console.WriteLine($"Сумма введенных чисел равна {summ}");
        Console.WriteLine($"Произведение введенных чисел равно {total}");
        Console.WriteLine($"Среднее введенных чисел равно {average}");
    }
}