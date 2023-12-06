namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.5\ConsoleApp1\numsTask1.txt";
        int min = int.MaxValue;
        int total = 1;

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

            for (int i = minIndex + 1; i < nums.Length; i++)
            {
                int number = Convert.ToInt32(nums[i]);
                total *= number;
            }
            
            Console.WriteLine($"Произведение элементов, расположенных после минимального, равно {total}.");
        }
    }
}