// public class Reference
// {
//     public string Book { get; set; }
//     public int Chapter { get; set; }
//     public int Verse { get; set; }
//     public int? EndVerse { get; set; } // Nullable for verse ranges

//     // Constructor for single verse
//     public Reference(string book, int chapter, int verse, int? endVerse = null)
//     {
//         Book = book;
//         Chapter = chapter;
//         Verse = verse;
//         EndVerse = endVerse;
//     }

//     // Static method to parse a reference string (e.g., "Alma 7:11-13")
//     public static Reference Parse(string referenceText)
//     {
//         string[] parts = referenceText.Split(new[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

//         string book = string.Join(" ", parts.Take(parts.Length - 3));
//         int chapter = int.Parse(parts[parts.Length - 3]);
//         int verse = int.Parse(parts[parts.Length - 2]);
//         int? endVerse = parts.Length > 3 ? int.Parse(parts[parts.Length - 1]) : null;

//         return new Reference(book, chapter, verse, endVerse);
//     }

//     public string GetDisplayText()
//     {
//         return EndVerse.HasValue
//             ? $"{Book} {Chapter}:{Verse}-{EndVerse}"
//             : $"{Book} {Chapter}:{Verse}";
//     }
// }

// 
// Reference class for scripture reference details
public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int Verse { get; set; }
    public int? EndVerse { get; set; } // Nullable for range references

    // Constructor for single verse
    public Reference(string book, int chapter, int verse, int? endVerse = null)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return EndVerse.HasValue
            ? $"{Book} {Chapter}:{Verse}-{EndVerse}"
            : $"{Book} {Chapter}:{Verse}";
    }
}
