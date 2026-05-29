using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Epic car", "Alex", 1.82);

        Comment comment1 = new Comment("Jorge", "Nice video");
        Comment comment2 = new Comment("Alan", "Woooow");
        Comment comment3 = new Comment("Fabian", "Wow that car is reallly nice");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video("Best day", "Alex", 2.50);

        Comment comment4 = new Comment("Ana", "Wow way to go Alex");
        Comment comment5 = new Comment("Andrea", "I really like your videos you should upload more!!");
        Comment comment6 = new Comment("Jose", "I wish I was there!!");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video("Family Vacations", "Alex", 3.00);

        Comment comment7 = new Comment("Isabel", "What a nice family!");
        Comment comment8 = new Comment("Sandra", "Where did you go?");
        Comment comment9 = new Comment("Rodrigo", "How much was the fee for the place?");

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetDisplayText());
            }

            Console.WriteLine();
        }
    }
}