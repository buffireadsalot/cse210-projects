using System;
using System.Collections.Generic;
using System.IO;

// class GoalManager
// {
//     private List<Goal> goals = new List<Goal>();
//     private int userScore = 0;
//     private string fileName;

//     public void Run()
//     {
//         Console.Write("Enter a filename to use (e.g., mygoals.txt): ");
//         fileName = Console.ReadLine();

//         LoadGoals();  

//         bool exit = false;
//         while (!exit)
//         {
//             Console.Clear();
//             Console.WriteLine("=== Goal Tracker ===");
//             Console.WriteLine($"Your Score: {userScore}");
//             Console.WriteLine("1. Create a Goal");
//             Console.WriteLine("2. Record a Goal Event");
//             Console.WriteLine("3. Show Goals");
//             Console.WriteLine("4. Delete a Goal");
//             Console.WriteLine("5. Save Goals");
//             Console.WriteLine("6. Exit");
//             Console.Write("Choose an option: ");

//             switch (Console.ReadLine())
//             {
//                 case "1":
//                     CreateGoal();
//                     break;
//                 case "2":
//                     RecordGoalEvent();
//                     break;
//                 case "3":
//                     ShowGoals();
//                     break;
//                 case "4":
//                     DeleteGoal();
//                     break;
//                 case "5":
//                     SaveGoals();
//                     break;
//                 case "6":
//                     exit = true;
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Try again.");
//                     break;
//             }
//             Console.WriteLine("\nPress Enter to continue...");
//             Console.ReadLine();
//         }
//     }

//     private void CreateGoal()
//     {
//         Console.WriteLine("\nChoose goal type:");
//         Console.WriteLine("1. Simple Goal (one-time completion)");
//         Console.WriteLine("2. Eternal Goal (repeatable)");
//         Console.WriteLine("3. Checklist Goal (requires multiple completions)");
//         Console.Write("Select goal type: ");
//         string choice = Console.ReadLine();

//         Console.Write("Enter goal name: ");
//         string name = Console.ReadLine();
//         Console.Write("Enter goal description: ");
//         string description = Console.ReadLine();
//         Console.Write("Enter points for completion: ");
//         int points = int.Parse(Console.ReadLine());

//         switch (choice)
//         {
//             case "1":
//                 goals.Add(new SimpleGoal(name, description, points));
//                 break;
//             case "2":
//                 goals.Add(new EternalGoal(name, description, points));
//                 break;
//             case "3":
//                 Console.Write("Enter target count to complete: ");
//                 int target = int.Parse(Console.ReadLine());
//                 Console.Write("Enter bonus points for completing: ");
//                 int bonus = int.Parse(Console.ReadLine());
//                 goals.Add(new ChecklistGoal(name, description, points, target, bonus));
//                 break;
//             default:
//                 Console.WriteLine("Invalid choice.");
//                 break;
//         }

//         Console.WriteLine("Goal created successfully!");
//     }

//     private void RecordGoalEvent()
//     {
//         ShowGoals();
//         Console.Write("Enter the goal number to record progress: ");
//         int index = int.Parse(Console.ReadLine()) - 1;

//         if (index >= 0 && index < goals.Count)
//         {
//             int pointsEarned = goals[index].RecordEvent();
//             userScore += pointsEarned;
//             Console.WriteLine($"Progress recorded! You earned {pointsEarned} points.");

//             if (goals[index] is ChecklistGoal checklistGoal && checklistGoal._isCompleted)
//             {
//                 Console.Write("This goal is complete. Do you want to renew it? (yes/no): ");
//                 if (Console.ReadLine().ToLower() == "yes")
//                 {
//                     checklistGoal.RenewGoal();
//                     Console.WriteLine("Checklist goal has been reset!");
//                 }
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid goal selection.");
//         }
//     }

//     private void ShowGoals()
//     {
//         Console.WriteLine("\nYour Goals:");
//         for (int i = 0; i < goals.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} - {goals[i]._description}");
//         }
//     }

//     private void DeleteGoal()
//     {
//         ShowGoals();
//         Console.Write("Enter the goal number to delete: ");
//         int index = int.Parse(Console.ReadLine()) - 1;

//         if (index >= 0 && index < goals.Count)
//         {
//             Console.WriteLine($"Deleting goal: {goals[index]._name}");
//             goals.RemoveAt(index);
//             Console.WriteLine("Goal deleted successfully.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid goal selection.");
//         }
//     }

//     private void SaveGoals()
//     {
//         using (StreamWriter writer = new StreamWriter(fileName))
//         {
//             writer.WriteLine($"Score: {userScore}");
//             foreach (Goal goal in goals)
//             {
//                 writer.WriteLine($"{goal.GetType().Name},{goal._name},{goal._description},{goal._points},{goal._isCompleted}");
//             }
//         }
//         Console.WriteLine($"Goals saved to {fileName} successfully!");
//     }

//     private void LoadGoals()
//     {
//         if (File.Exists(fileName))
//         {
//             goals.Clear();
//             using (StreamReader reader = new StreamReader(fileName))
//             {
//                 string scoreLine = reader.ReadLine();
//                 userScore = int.Parse(scoreLine.Split(':')[1].Trim());

//                 string line;
//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     string[] parts = line.Split(',');
//                     goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { _isCompleted = bool.Parse(parts[4]) });
//                 }
//             }
//             Console.WriteLine($"Goals loaded from {fileName}.");
//         }
//         else
//         {
//             Console.WriteLine("No saved goals found.");
//         }
//     }
// }


class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int userScore = 0;
    private string fileName;

    public void Run()
    {
        Console.Write("Enter a filename to use (e.g., mygoals.txt): ");
        fileName = Console.ReadLine();

        LoadGoals();  

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Goal Tracker ===");
            Console.WriteLine($"Your Score: {userScore}");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Record a Goal Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Delete a Goal"); //Added delete to the menu
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordGoalEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    DeleteGoal();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Simple Goal (one-time completion)");
        Console.WriteLine("2. Eternal Goal (repeatable)");
        Console.WriteLine("3. Checklist Goal (requires multiple completions)");
        Console.Write("Select goal type: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
    }

    private void RecordGoalEvent()
    {
        ShowGoals();
        Console.Write("Enter the goal number to record progress: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            int pointsEarned = goals[index].RecordEvent();
            userScore += pointsEarned;
            Console.WriteLine($"Progress recorded! You earned {pointsEarned} points.");
            //Added a renew for the checklist goal so it can be reset once completed
            if (goals[index] is ChecklistGoal checklistGoal && checklistGoal._isCompleted)
            {
                Console.Write("This goal is complete. Do you want to renew it? (yes/no): ");
                if (Console.ReadLine().ToLower() == "yes")
                {
                    checklistGoal.RenewGoal();
                    Console.WriteLine("Checklist goal has been reset!");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} - {goals[i]._description}");
        }
    }

    private void DeleteGoal()
    {
        ShowGoals();
        Console.Write("Enter the goal number to delete: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count)
        {
            Console.WriteLine($"Deleting goal: {goals[index]._name}");
            goals.RemoveAt(index);
            Console.WriteLine("Goal deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Score: {userScore}");
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal._name},{goal._description},{goal._points},{goal._isCompleted}");
            }
        }
        Console.WriteLine($"Goals saved to {fileName} successfully!");
    }

    private void LoadGoals()
    {
        if (File.Exists(fileName))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string scoreLine = reader.ReadLine();
                userScore = int.Parse(scoreLine.Split(':')[1].Trim());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { _isCompleted = bool.Parse(parts[4]) });
                }
            }
            Console.WriteLine($"Goals loaded from {fileName}.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}