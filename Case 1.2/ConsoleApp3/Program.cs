namespace ConsoleApp3;

class Program
{
    static void Main()
    {
        int n = 0;
        Console.Write("Введите размерность матрицы -> ");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] nums = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            nums[i, 0] = 1;
            nums[0, i] = 1;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (nums[i, j] != 1)
                {
                    nums[i, j] = nums[i - 1, j] + nums[i, j - 1];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{nums[i, j], -5}");
            }
        }
    }
}