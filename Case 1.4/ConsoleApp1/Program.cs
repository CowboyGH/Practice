namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        Console.Write("Введите число -> ");
        int n = Convert.ToInt32(Console.ReadLine());
        int total = 1;

        int[] array = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            array[i] = i;
            if (array[i] > 0 && array[i] % 3 == 0)
            {
                total *= array[i];
            }
        }
        
        Console.Write($"Произведение натуральных чисел, кратных трём и не превышающих число {n} равно {total}.");
    }
}