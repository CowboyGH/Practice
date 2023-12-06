namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        const int N = 100;
        int num = 2;
        int[] nums = new int[N];

        for (int i = 0; i < N; i++)
        {
            nums[i] = 1 + i * num;
        }
    }
}