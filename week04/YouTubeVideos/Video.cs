// using System.Diagnostics;


// public class Video
// {
//     private string _title { get; set; }
//     private string _url { get; set; }
//     private string _author { get; set; }
//     private string _description { get; set; }
    
//     private decimal _durationSeconds { get; set; }

//     private  Comments Comment { get; set; }

  


//     public Video(string title, string url, string description, Comments Comment, decimal durationSeconds)
//     {
//         _title = title;
//         _url = url;
//         _description = description;
//         Comments comment = Comment;
//         _durationSeconds = durationSeconds;

//     }
    
//     List<Video> videos = new List<Video>
//     {
//         new Video("C# Tutorial", "https://www.youtube.com/watch?v=1X6tP4Hb1Q4", "Learn C# in one video", new Comments(), 60),
//         new Video("Python Tutorial", "https://www.youtube.com/watch?v=rfscVS0vtbw", "Learn Python in one video", new Comments(), 60),
//         new Video("Java Tutorial", "https://www.youtube.com/watch?v=grEKMHGYyns", "Learn Java in one video", new Comments(), 60)
//     };
//     public string GetComments() 
//     {
//     // Get comments from the YouTube API
//        return $"Comments for {_title} ({_url})";
//     }
//     public override string ToString()
//     {
//         return $"{_title} ({_url})  {_durationSeconds}/nList of comments {Comments}";
// // public void AddComment(string comment, string author)
   
//        List<Video> videos = new List<Video>
//        {
//            new Video("C# Tutorial", "https://www.youtube.com/watch?v=1X6tP4Hb1Q4", "Learn C# in one video", "Great video", 60),
//            new Video("Python Tutorial", "https://www.youtube.com/watch?v=rfscVS0vtbw", "Learn Python in one video", "Great video", 60),
//            new Video("Java Tutorial", "https://www.youtube.com/watch?v=grEKMHGYyns", "Learn Java in one video", "Great video", 60)
//        };

//      string GetDebuggerDisplay()
//     {
//         return ToString();
//     }
// }


public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string author, string text)
    {
        Comments.Add(new Comment(author, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {LengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"  - {comment}");
        }
        Console.WriteLine("-----------------------------------");
    }
}