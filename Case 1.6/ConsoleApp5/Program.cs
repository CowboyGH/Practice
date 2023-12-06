namespace ConsoleApp5;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы -> ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите количество столбцов матрицы -> ");
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Числа строки {i + 1}: ");
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[,] updMatrix = new int[n, m + 1];

        for (int i = 0; i < n; i++)
        {
            int count = 0;

            for (int j = 0; j < m; j++)
            {
                updMatrix[i, j] = matrix[i, j];
                
                if (matrix[i, j] == 1)
                {
                    count++;
                }

                if (count % 2 != 0)
                {
                    updMatrix[i, m] = 1;
                }
                else
                {
                    updMatrix[i, m] = 0;
                }
            }
        }
        
        Console.Write("Обновленная матрица:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write($"{updMatrix[i, j], -5}");
            }
        }
    }
}