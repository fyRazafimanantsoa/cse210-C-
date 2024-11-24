using System;

public class Program
{
    public static void Main(string[] args)
    {
        var scripture = new Scripture("John 3:16", "For God so loved the world that He gave His only begotten Son, that whosoever believeth in Him should not perish but have everlasting life.");
        
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");

            // Check if all words are hidden
            if (scripture.GetWords().All(w => w.IsHidden()))
            {
                Console.Clear();
                Console.WriteLine("All words are hidden.\n");
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Well done! You have completed the scripture memorization.");
                break; // Exit the loop
            }

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input == "")
            {
                scripture.HideRandomWords();
            }
        }
    }
}
