using System;

class Program
{
    static void Main()
    {
        Video video1 = new Video("Introduction to Database", "John Doe", 600);
        Video video2 = new Video("Programming Building blocks", "Jane Smith", 720);
        Video video3 = new Video("C# Advanced Topics", "Alice Johnson", 900);

        
        video1.Comments.Add(new Comment("User1", "Great video!"));
        video1.Comments.Add(new Comment("User2", "Very helpful content."));

        video2.Comments.Add(new Comment("User3", "Could you provide more examples?"));
        video2.Comments.Add(new Comment("User4", "I enjoyed learning from this video."));

        video3.Comments.Add(new Comment("User5", "This is exactly what I needed."));
        video3.Comments.Add(new Comment("User6", "Thanks for the clear explanation."));

       
        List<Video> videos = new List<Video> { video1, video2, video3 };

        
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine(); //
        }
    }
}