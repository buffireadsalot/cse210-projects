using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>
        {
            new Video("C# Tutorial", "Tech Guru", 600),
            new Video("Python Basics", "Code Academy", 900),
            new Video("Java Programming", "Dev World", 1200)
        };

        videos[0].AddComment("Alice", "Great tutorial! Very helpful.");
        videos[0].AddComment("Bob", "I love the explanations.");
        videos[0].AddComment("Charlie", "This helped me a lot, thanks!");

        videos[1].AddComment("David", "Python is amazing!");
        videos[1].AddComment("Eve", "Could you explain loops in more detail?");
        videos[1].AddComment("Frank", "I finally understand dictionaries, thanks!");

        videos[2].AddComment("Grace", "Java seems tough, but this helped.");
        videos[2].AddComment("Hank", "Can you make an advanced Java course?");
        videos[2].AddComment("Ivy", "Really good content!");

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}