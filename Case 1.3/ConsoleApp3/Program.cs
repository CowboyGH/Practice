namespace ConsoleApp3;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.3\ConsoleApp3\height.txt";

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string str = stream.ReadLine();
            string[] nums = str.Split(",");

            int[] height = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                height[i] = Convert.ToInt32(nums[i]);
            }

            int left = 0;                               // левая граница
            int right = height.Length - 1;              // правая граница
            int max = 0;                                // максимальная площадь

            while (left < right)
            {
                int min = height[left] < height[right] ? height[left] : height[right];  // вычисляем минимальную высоту  

                max = max > min * (right - left) ? max : min * (right - left);          // находим максимальную площадь (min * S)

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            
            stream.Close();

            using (StreamWriter writer = new StreamWriter(inputPath))
            {
                writer.Write(max);
            }
        }
    }
}