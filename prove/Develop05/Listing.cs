public class ListingActivity : MindfulnessActivity
    {
        private static readonly List<string> Prompts = new()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };

        public void Run()
        {
            StartActivity("Listing Activity", "This activity will help you list things you are grateful for.");
            Random random = new();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Console.WriteLine("Start listing items:");

            int itemCount = 0;
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items!");
            EndActivity("Listing Activity");
        }
    }