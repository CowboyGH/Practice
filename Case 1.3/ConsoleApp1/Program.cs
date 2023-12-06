namespace ConsoleApp1;

class Program
{
    static void Main()
    {
        string inputPath = @"C:\Users\gr622_kodal\RiderProjects\Laba 1.3\ConsoleApp1\input.txt";
        string[] inputLines = File.ReadAllLines(inputPath);
                                                                            
        string[] keyNums = inputLines[0].Split(' ');                 //  Номера, выбранные организаторами
        int numsOfTickets = Convert.ToInt32(inputLines[1]);                 // Количество выданных билетов

        List<string> result = new List<string>();                           // результаты розыгрыша

        for (int i = 0; i < numsOfTickets; i++)
        {
            int matchCount = 0;
            string[] ticketNums = inputLines[i + 2].Split(' ');

            foreach (var number1 in keyNums)
            {
                foreach (var number2 in ticketNums)
                {
                    if (number1 == number2)
                    {
                        matchCount++;
                    }
                }
            }

            if (matchCount >= 3)
            {
                result.Add("Lucky");
            }
            else
            {
                result.Add("Unlucky");
            }
        }

        File.WriteAllLines(@"C:\Users\gr622_kodal\RiderProjects\Laba 1.3\ConsoleApp1\output.txt", result.ToArray());
    }
}