namespace ConsoleApp3;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.4\ConsoleApp3\numsTask3.txt";

        int min = int.MaxValue;
        float max = 0;

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(",");

            foreach (var member in nums)
            {
                int number = int.Parse(member);
                
                if (number > 0)
                {
                    if (min > number)
                    {
                        min = number;
                    }
                    if (max < number)
                    {
                        max = number;
                    }
                }
                else if (number == 0)
                {
                    break;
                }
            }
        }
        
        float ratio = min / max;
        Console.WriteLine($"Отношение минимального и максимального элементов составляет {ratio}.");
    }
}