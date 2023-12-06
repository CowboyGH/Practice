namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.3\ConsoleApp2\nums.txt";

        string nums = File.ReadAllText(inputPath);
        File.WriteAllText(inputPath, "");           // очищаем файл
        string result = "";
        
        foreach (var number in nums.Split(" "))
        {
            if (int.Parse(number) % 2 != 0 && number != "")
            {
                result += number + ' ';
            }
        }
        
        File.WriteAllText(inputPath, result);
    }
}