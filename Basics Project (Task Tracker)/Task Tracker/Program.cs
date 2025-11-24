namespace Task_Tracker
{
    internal class Program
    {
        static List<TaskItem> Tasks = new List<TaskItem>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Task Tracker App");
            Console.WriteLine("---------------------------");

            while (true)
            {
                Console.WriteLine("Please enter a number from 1 to 5:");
                Console.WriteLine("1. View All Tasks");
                Console.WriteLine("2. Add New Task");
                Console.WriteLine("3. Mark Task As Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        ShowAllTasks();
                        break;
                    case "2":
                        AddTask();
                        break;
                    case "3":
                        MarkTaskAsCompleted();
                        break;
                    case "4":
                        DeleteTask();
                        break;
                    case "5":
                        Console.WriteLine("See You Soon!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
            }
        }

        public static void ShowAllTasks()
        {
            if(Tasks.Count == 0)
            {
                Console.WriteLine("No Tasks Yet");
                return;
            }

            Console.WriteLine("\nYour Tasks:");
            for(int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tasks[i].Title} - {Tasks[i].Status}");
            }
        }
        public static void AddTask()
        {
            Console.Write("Enter The Task Title: ");
            string newTaskTitle = Console.ReadLine();
            Tasks.Add(new TaskItem(newTaskTitle, "Pending"));
            Console.WriteLine("Task added successfully!");
        }
        public static void MarkTaskAsCompleted()
        {
            ShowAllTasks();
            Console.Write("Please Enter The Number Of Completed Task: ");
            string StringTaskIndex = Console.ReadLine();

            if(int.TryParse(StringTaskIndex, out int result) && result > 0 && result <= Tasks.Count)
            {
                Tasks[result - 1].Status = "Completed";
                Console.WriteLine($"Task: {Tasks[result - 1].Title} is marked as Completed");
            } else
            {
                Console.WriteLine("Invalid Task Number");
            }
        }
        public static void DeleteTask()
        {
            ShowAllTasks();
            Console.Write("Enter The Task Number To Delete:");

            if (int.TryParse(Console.ReadLine(), out int result) && result > 0 && result <= Tasks.Count)
            {
                Tasks.RemoveAt(result - 1);
                Console.WriteLine("Task Deleted Successfully");
            } else
            {
                Console.WriteLine("Invalid Task Number");
            }
        }
    }

    class TaskItem
    {
        public string Title { get; set; }
        public string Status { get; set; }

        public TaskItem(string title, string status)
        {
            Title = title;
            Status = status;
        }
    }
}
