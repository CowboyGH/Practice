namespace ConsoleApp3;

class Program
{
    static void Main()
    {
        Console.Write("Введите число -> ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0 && number % 10 == 0)
        {
            Console.WriteLine($"Число {number} является чётным и кратным 10.");
        }
        else
        {
            Console.WriteLine($"Число {number} не является чётным и кратным 10.");
        }
    }
}