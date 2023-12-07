using Newtonsoft.Json;

namespace ConsolePlanner;

class Program
{
    static List<Task> tasks = new List<Task>();
    static string jsonName = "statham.json";
    
    static void Main()
    {
        if (File.Exists(jsonName))
        {
            string json = File.ReadAllText(jsonName);
            tasks = JsonConvert.DeserializeObject<List<Task>>(json);
        }
        
        Console.WriteLine("Let's Start!");

        while (true)
        {
            Console.WriteLine("Press 1 to Add Task");
            Console.WriteLine("Press 2 to Edit Task");
            Console.WriteLine("Press 3 to Delete Task");
            Console.WriteLine("Press 4 to View All Tasks");
            Console.WriteLine("Press 5 to View Upcoming Tasks");
            Console.WriteLine("Press 6 to View Completed Tasks");
            Console.WriteLine("Press 7 to View Tasks for Today");
            Console.WriteLine("Press 8 to View Tasks for Tomorrow");
            Console.WriteLine("Press 9 to View Tasks for a Week");
            Console.WriteLine("Press 0 to Close App");
            
            int selectedNum = Convert.ToInt32(Console.ReadLine());

            switch (selectedNum)
            {
                case 1:
                {
                    AddTask();
                    break;
                }
                case 2:
                {
                    EditTask();
                    break;
                }
                case 3:
                {
                    DeleteTask();
                    break;
                }
                case 4:
                {
                    ShowAllTasks();
                    break;
                } 
                case 5:
                {
                    ShowUpcomingTasks();
                    break;
                } 
                case 6:
                { 
                    ShowCompletedTasks();
                    break;   
                } 
                case 7:
                {
                    ShowTasksForToday();
                    break;
                } 
                case 8:
                {
                    ShowTasksForTomorrow();
                    break;
                }
                case 9:
                {
                    ShowTasksForAWeek();
                    break;
                }
                case 0:
                {
                    SaveAllTasks();
                    return;
                }
                default:
                    Console.WriteLine("Incorrect action.");
                    break;
            }
            Console.WriteLine();
        }
    }
    
    static void AddTask()
    {
        Task task = new Task();
                
        Console.Write("Task name: ");
        task.nameOfTask = Console.ReadLine();
                
        Console.WriteLine("Task description:");
        task.descOfTask = Console.ReadLine();
                
        Console.Write("Date of execution (yyyy-mm-dd format): ");
        task.dateOfTask = DateTime.Parse(Console.ReadLine());

        tasks.Add(task);

        Console.WriteLine("Task successfully added.");
    }
    
    static void EditTask()
    { 
        Console.Write("Enter the name of the task to edit: "); 
        string taskName = Console.ReadLine();
        
        Task taskToEdit = tasks.Find(t => t.nameOfTask.Equals(taskName, StringComparison.OrdinalIgnoreCase));       // !!!
        
        if (taskToEdit != null) 
        {
            Console.Write("Enter a new task name: "); 
            string newName = Console.ReadLine();
            
            Console.Write("Enter a new task description: "); 
            string newDesc = Console.ReadLine();
            
            Console.Write("Enter a new date of execution (yyyy-mm-dd format): "); 
            string newDate = Console.ReadLine();
            
            taskToEdit.nameOfTask = newName;
            
            taskToEdit.descOfTask = newDesc;
            
            taskToEdit.dateOfTask = DateTime.Parse(newDate); 
            
            Console.WriteLine("Task successfully edited.");
        }
        else
        {
            Console.WriteLine("Error 404. Task not found.");
        }
    }
    
    static void DeleteTask() 
    {
        Console.Write("Enter the name of the task to be deleted: "); 
        string taskName = Console.ReadLine();
        
        Task taskToRemove = tasks.Find(t => t.nameOfTask.Equals(taskName, StringComparison.OrdinalIgnoreCase));     // !!!
        
        if (taskToRemove != null) 
        { 
            tasks.Remove(taskToRemove); 
            Console.WriteLine("Task successfully deleted.");
        }
        else 
        {
            Console.WriteLine("Error 404. Task not found.");
        }
    }
    
    static void ShowAllTasks()
    {
        Console.WriteLine("List of all tasks:");

        foreach (Task task in tasks)
        {
            Console.WriteLine($"Name: {task.nameOfTask}");
            Console.WriteLine($"Description: {task.descOfTask}");
            Console.WriteLine($"Date: {task.dateOfTask}");
            Console.WriteLine();
        }

        if (tasks.Count == 0)
        {
            Console.WriteLine("Task list is empty");
        }
    }

    static void ShowUpcomingTasks()
    {
        Console.WriteLine("List of upcoming tasks:");

        foreach (Task task in tasks)
        {
            if (task.dateOfTask.Date >= DateTime.Today)
            {
                Console.WriteLine($"Name: {task.nameOfTask}");
                Console.WriteLine($"Description: {task.descOfTask}");
                Console.WriteLine($"Date: {task.dateOfTask}");
                Console.WriteLine();
            }
        }

        if (tasks.Count == 0)
        {
            Console.WriteLine("No upcoming tasks.");
        }
    }

    static void ShowCompletedTasks()
    {
        Console.WriteLine("List of completed tasks:");

        foreach (Task task in tasks)
        {
            if (task.dateOfTask.Date < DateTime.Today)
            {
                Console.WriteLine($"Name: {task.nameOfTask}");
                Console.WriteLine($"Description: {task.descOfTask}");
                Console.WriteLine($"Date: {task.dateOfTask}");
                Console.WriteLine(); 
            }
        }

        if (tasks.Count == 0)
        { 
            Console.WriteLine("No tasks completed.");
        }
    }
    
    static void ShowTasksForToday()
    {
        Console.WriteLine("Tasks for today:"); 
        bool foundTasks = false;
        
        foreach (Task task in tasks) 
        { 
            if (task.dateOfTask.Date == DateTime.Today) 
            { 
                Console.WriteLine($"Name: {task.nameOfTask}"); 
                Console.WriteLine($"Description: {task.descOfTask}"); 
                Console.WriteLine($"Date: {task.dateOfTask}"); 
                Console.WriteLine();
                
                foundTasks = true;
            }
        }

        if (foundTasks == false)
        {
            Console.WriteLine("No tasks for today.");
        }
    }
    
    static void ShowTasksForTomorrow()
    {
        Console.WriteLine("Tasks for tomorrow:"); 
        bool foundTasks = false;
        
        foreach (Task task in tasks) 
        { 
            if (task.dateOfTask.Date == DateTime.Today.AddDays(1)) 
            { 
                Console.WriteLine($"Name: {task.nameOfTask}"); 
                Console.WriteLine($"Description: {task.descOfTask}"); 
                Console.WriteLine($"Date: {task.dateOfTask}"); 
                Console.WriteLine();
                
                foundTasks = true;
            }
        }

        if (foundTasks == false)
        {
            Console.WriteLine("No tasks for tomorrow.");
        }
    }
    
    static void ShowTasksForAWeek()
    {
        Console.WriteLine("Tasks for a week:"); 
        bool foundTasks = false;
        
        foreach (Task task in tasks) 
        { 
            if (task.dateOfTask.Date == DateTime.Today.AddDays(7)) 
            { 
                Console.WriteLine($"Name: {task.nameOfTask}"); 
                Console.WriteLine($"Description: {task.descOfTask}"); 
                Console.WriteLine($"Date: {task.dateOfTask}"); 
                Console.WriteLine();
                
                foundTasks = true;
            }
        }

        if (foundTasks == false)
        {
            Console.WriteLine("No tasks for a week.");
        }
    }

    static void SaveAllTasks()
    {
        string json = JsonConvert.SerializeObject(tasks);
        File.WriteAllText(jsonName, json);
    }
}