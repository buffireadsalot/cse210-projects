using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

// Main Program
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ListingActivity(),
                "3" => new ReflectingActivity(),
                "4" => null,
                _ => null
            };

            if (choice == "4" || activity == null)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Clear();
            activity.Run();
        }
    }
}

//  bool running = true;
//         while (running)
//         {
//             Console.WriteLine("What would you like to do?");
//             Console.WriteLine("1. Add a task");
//             Console.WriteLine("2. View a task");
//             Console.WriteLine("3. Mark a task as complete");
//             Console.WriteLine("4. Exit");
//             string choice = Console.ReadLine();
//             switch (choice)
//             {
//                 case "1":
//                     Console.WriteLine("Enter a task description");
//                     string description = Console.ReadLine();
//                     ToDoList.AddTask();
//                     ToDoList.AddTask();
//                     break;
//                 case "2":
//                     ToDoList.ViewTasks();
//                     break;
//                 case "3":
//                     ToDoList.CompleteTask();
//                     break;
//                 case "4":
//                     running = false;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice");
//                     break;