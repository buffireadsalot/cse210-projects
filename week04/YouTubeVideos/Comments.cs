// public class Comments
// {
//     private string _comment { get; set; }
//     private string _author { get; set; }
//     private string _date { get; set; }
//     private Video Title { get; set; }

//     public Comments(string comment, string author, string date, Video title)
//     {
//         _comment = comment;
//         _author = author;
//         _date = date;
//         Video Title = title;
//     }

//     public Video title
//     {
//         get { return Title; }
//         set { Title = value; }
//     }

//     public string Comment { get => _comment; set => _comment = value; }

//     public override string ToString()
//     {
//         return $"{_comment} ({_author}) {_date}";
//     }

    
// }

using System;
using System.Collections.Generic;

public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Author}: {Text}";
    }
}