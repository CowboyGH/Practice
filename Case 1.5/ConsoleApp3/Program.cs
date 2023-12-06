namespace ConsoleApp3;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.5\ConsoleApp3\numsTask3.txt";
        int min = int.MaxValue;
        float average = 0;

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(' ');
            int minIndex = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                if (min > number)
                {
                    min = number;
                    minIndex = i;
                }
            }
            
            for (int i = 0; i < minIndex; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                average += number;
            }
            
            average /= minIndex;
            Console.WriteLine($"Среднее арифметическое элементов, расположенных до минимального, равно {average}.");
        }
    }
}