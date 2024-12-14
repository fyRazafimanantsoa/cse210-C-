using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEternal Quest - Main Menu");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Event");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Load Goals");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter goal points: ");
                        int points = int.Parse(Console.ReadLine());

                        Console.WriteLine("Choose goal type:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.Write("Enter your choice: ");
                        string type = Console.ReadLine();

                        Goal goal = type switch
                        {
                            "1" => new SimpleGoal(name, description, points),
                            "2" => new EternalGoal(name, description, points),
                            "3" => AddChecklistGoal(name, description, points),
                            _ => null
                        };

                        if (goal != null)
                        {
                            manager.AddGoal(goal);
                            Console.WriteLine("Goal added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid goal type.");
                        }
                        break;

                    case "2":
                        manager.DisplayGoals();
                        Console.Write("Enter the goal number to record an event: ");
                        int goalIndex = int.Parse(Console.ReadLine()) - 1;
                        manager.RecordEvent(goalIndex);
                        Console.WriteLine("Event recorded.");
                        break;

                    case "3":
                        Console.WriteLine("\nYour Goals:");
                        manager.DisplayGoals();
                        Console.WriteLine($"\nTotal Score: {manager.GetScore()}");
                        break;

                    case "4":
                        Console.Write("Enter the filename to save: ");
                        string saveFile = Console.ReadLine();
                        manager.SaveGoals(saveFile);
                        Console.WriteLine("Goals saved successfully.");
                        break;

                    case "5":
                        Console.Write("Enter the filename to load: ");
                        string loadFile = Console.ReadLine();
                        manager.LoadGoals(loadFile);
                        Console.WriteLine("Goals loaded successfully.");
                        break;

                    case "6":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static ChecklistGoal AddChecklistGoal(string name, string description, int points)
        {
            Console.Write("Enter the required number of completions: ");
            int requiredTimes = int.Parse(Console.ReadLine());
            Console.Write("Enter the bonus points for completion: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            return new ChecklistGoal(name, description, points, requiredTimes, bonusPoints);
        }
    }
}
