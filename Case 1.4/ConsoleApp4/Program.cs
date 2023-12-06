namespace ConsoleApp4;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.4\ConsoleApp4\numsTask4.txt";
        
        int count = 0;

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(" ");
            
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i-1])
                {
                    count++;
                }
            }
        }
        Console.WriteLine($"Количество одинаковых рядом стоящих чисел равно {count * 2}.");
    }
}