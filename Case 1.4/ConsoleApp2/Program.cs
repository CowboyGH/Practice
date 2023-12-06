namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.4\ConsoleApp2\numsTask2.txt";
        
        float sum = 0;

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(";");

            foreach (var member in nums)
            {
                float number = float.Parse(member);
                
                if (number > 0)
                {
                    sum += number;
                }
                else if (number == 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine($"Сумма положительных элементов последовательности равна {sum}.");
    }
}