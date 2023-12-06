namespace ConsoleApp5;

class Program
{
    const int Months = 12;
    const int Days = 30;


    static Dictionary<string, int[]> Avgtemp(Dictionary<string, int[]> yearTemp)
    {
        Dictionary<string, int[]> avgDict = new Dictionary<string, int[]>();
        
        foreach (var month in yearTemp)
        {
            int[] temperatures = month.Value;
            int sum = 0;

            foreach (int temp in temperatures)
            {
                sum += temp;
            }

            int avgTemperature = sum / Days;
            avgDict.Add(month.Key, new int[]{avgTemperature});
        }
        
        return avgDict;
    }
    
    
    static void Main()
    {
        Dictionary<string, int[]> yearTemp = new Dictionary<string, int[]>();
        Random rand = new Random();
        
        string[] namesOfMonths = 
        {
            "January", "February", "March",
            "April", "May", "June",
            "July", "August", "September",
            "October", "November", "December"
        };

        for (int i = 0; i < Months; i++)
        {
            int[] monthTemp = new int[Days];
            
            for (int j = 0; j < Days; j++)
            {
                monthTemp[j] = rand.Next(15, 40);
            }
            
            yearTemp.Add(namesOfMonths[i], monthTemp);
        }
        
        Dictionary<string, int[]> avgDict = Avgtemp(yearTemp);

        foreach (var month in avgDict)
        {
            Console.WriteLine($"{month.Key} -> {string.Join(",", month.Value)}");
        }
    }
}