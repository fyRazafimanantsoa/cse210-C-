using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video objects
        Video video1 = new Video("How to Cook Pasta", "Chef Mario", 300);
        Video video2 = new Video("Guitar Basics", "Music Mike", 450);
        Video video3 = new Video("Yoga for Beginners", "Yoga Yogi", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video, learned a lot!"));
        video1.AddComment(new Comment("Bob", "Can you make a video on sauces?"));
        video1.AddComment(new Comment("Charlie", "This was helpful, thanks!"));

        // Add comments to video2
        video2.AddComment(new Comment("Diana", "I love this lesson."));
        video2.AddComment(new Comment("Eve", "What guitar model is that?"));
        video2.AddComment(new Comment("Frank", "Thanks for the tips!"));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Perfect for beginners."));
        video3.AddComment(new Comment("Hank", "Can you make an advanced version?"));
        video3.AddComment(new Comment("Ivy", "Feeling relaxed already!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
