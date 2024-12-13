using System;
  namespace MindfulnessApp
  {
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMindfulness Program");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new BreathingActivity().Run();
                        break;
                    case "2":
                        new ReflectionActivity().Run();
                        break;
                    case "3":
                        new ListingActivity().Run();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
  }