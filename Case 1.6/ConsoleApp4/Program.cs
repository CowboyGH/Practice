namespace ConsoleApp4;

class Program
{
    static void Main()
    {
        Console.Write("Введите делитель -> ");
        int divisor = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        Console.WriteLine("Введите положительные числа:");

        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num <= 0)
            {
                break;
            }
            
            if (num % divisor == 0)
            {
                sum += num;
            }
        }
        
        Console.WriteLine($"Cумма введенных чисел, делящихся на {divisor} нацело равна {sum}.");
    }
}