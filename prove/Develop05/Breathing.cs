public class BreathingActivity : MindfulnessActivity
    {
        public void Run()
        {
            StartActivity("Breathing Activity", "This activity will help you relax by guiding your breathing.");
            int cycles = Duration / 6; // Each cycle is 6 seconds (3 in, 3 out)
            for (int i = 0; i < cycles; i++)
            {
                Console.WriteLine("Breathe in...");
                Countdown(3);
                Console.WriteLine("Breathe out...");
                Countdown(3);
            }
            EndActivity("Breathing Activity");
        }
    }