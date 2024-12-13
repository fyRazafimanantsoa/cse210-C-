public class MindfulnessActivity
    {
        protected int Duration; // Duration of the activity in seconds

        public void StartActivity(string activityName, string description)
        {
            Console.WriteLine($"Welcome to the {activityName}.");
            Console.WriteLine(description);
            Console.Write("Enter the duration of the activity in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3);
        }

        public void EndActivity(string activityName)
        {
            Console.WriteLine("\nGreat job!");
            Console.WriteLine($"You have completed the {activityName} for {Duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds * 4; i++) // Each cycle is 0.25 seconds
            {
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b-");
                Thread.Sleep(250);
                Console.Write("\b\\");
                Thread.Sleep(250);
                Console.Write("\b|");
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }

        protected void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i} ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }