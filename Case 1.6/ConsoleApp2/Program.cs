namespace ConsoleApp2;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.6\ConsoleApp2\numsTask2.txt";

        using (StreamReader stream = new StreamReader(inputPath))
        {
            string[] strings = File.ReadAllLines(inputPath);
            string s = string.Empty;

            foreach (var word in strings)
            {
                s += word + ' ';
            }
            
            Console.WriteLine(s);
        }
    }
}