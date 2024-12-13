public class ReflectionActivity : MindfulnessActivity
    {
        private static readonly List<string> Prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private static readonly List<string> Questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?"
        };

        public void Run()
        {
            StartActivity("Reflection Activity", "This activity will help you reflect on your strengths.");
            Random random = new();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Console.WriteLine("Reflect on the following questions:");
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            while (DateTime.Now < endTime)
            {
                Console.WriteLine(Questions[random.Next(Questions.Count)]);
                ShowSpinner(5);
            }

            EndActivity("Reflection Activity");
        }
    }