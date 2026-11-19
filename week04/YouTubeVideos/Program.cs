
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create the first video
        Video video1 = new Video();
        video1._title = "Learning C#";
        video1._author = "Elder";
        video1._length = 300;

        // Create the second video
        Video video2 = new Video();
        video2._title = "Learning Python";
        video2._author = "Jerry";
        video2._length = 500;

        // Create the third video
        Video video3 = new Video();
        video3._title = "Learning JavaScript";
        video3._author = "Benjamin";
        video3._length = 700;

        // Create comments for the first video
        Comment comment1 = new Comment();
        comment1._commenterName = "Carlos";
        comment1._commentText = "Great explanation!";

        Comment comment2 = new Comment();
        comment2._commenterName = "Maria";
        comment2._commentText = "Very helpful!";

        Comment comment3 = new Comment();
        comment3._commenterName = "John";
        comment3._commentText = "Thanks for the tutorial!";

        // Add comments to the first video
        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        // Create comments for the second video
        Comment comment4 = new Comment();
        comment4._commenterName = "Anna";
        comment4._commentText = "Python is easy to understand!";

        Comment comment5 = new Comment();
        comment5._commenterName = "David";
        comment5._commentText = "Excellent tutorial for beginners!";

        Comment comment6 = new Comment();
        comment6._commenterName = "Sofia";
        comment6._commentText = "I learned a lot from this video!";

        // Add comments to the second video
        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        // Create comments for the third video
        Comment comment7 = new Comment();
        comment7._commenterName = "Michael";
        comment7._commentText = "JavaScript is very useful!";

        Comment comment8 = new Comment();
        comment8._commenterName = "Laura";
        comment8._commentText = "Great introduction to JavaScript!";

        Comment comment9 = new Comment();
        comment9._commenterName = "Daniel";
        comment9._commentText = "The examples were very clear!";

        // Add comments to the third video
        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);

        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(
                    $"{comment._commenterName}: {comment._commentText}"
                );
            }

            Console.WriteLine();
        }
    }
}
