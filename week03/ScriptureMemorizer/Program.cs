using System;
using System.Collections.Generic;
using System.IO;
using Pastel;
class Program

   
{
    static void Main(string[] args)
    {
        // Define scriptures directly in the program
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Alma", 7, 11, 13), 
                "And he shall go forth, suffering pains and afflictions and temptations of every kind."),
            new Scripture(new Reference("3 Nephi", 11, 10, 11), 
                "I have suffered the will of the Father in all things from the beginning."),
            new Scripture(new Reference("Ether", 12, 6), 
                "Ye receive no witness until after the trial of your faith.")
        };

        // Process each scripture one at a time
        foreach (var scripture in scriptures)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Scripture:");
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Press Enter to load the next scripture.");
                    Console.ReadLine();
                    break; // Move to the next scripture
                }

                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    return; // Exit the program
                }

                scripture.HideRandomWords(3); // Hide 3 random words
            }
        }

        Console.WriteLine("No more scriptures to display. Goodbye!");
    }
}
        //string fileName = "scriptures.txt";

    
        // Load scriptures from text file
    //     List<Scripture> scriptures = LoadScripturesFromFile(fileName);

    //     // Process each scripture one at a time
    //     foreach (var scripture in scriptures)
    //     {
    //         while (true)
    //         {
    //             Console.Clear();
    //             Console.WriteLine("Scripture:");
    //             Console.WriteLine(scripture.GetDisplayText());

    //             if (scripture.IsCompletelyHidden())
    //             {
    //                 Console.WriteLine("\nAll words are hidden. Press Enter to load the next scripture.");
    //                 Console.ReadLine();
    //                 break; // Move to the next scripture
    //             }

    //             Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
    //             string userInput = Console.ReadLine();

    //             if (userInput.ToLower() == "quit")
    //             {
    //                 Console.WriteLine("Goodbye!");
    //                 return; // Exit the program
    //             }

    //             scripture.HideRandomWords(3); // Hide 3 random words
    //         }
    //     }

    //     Console.WriteLine("No more scriptures to display. Goodbye!");
    // }

//     public static List<Scripture> LoadScripturesFromFile(string fileName)
// {
//     List<Scripture> scriptures = new List<Scripture>();

//     if (File.Exists(fileName))
//     {
//         string[] lines = File.ReadAllLines(fileName);

//         foreach (string line in lines)
//         {
//             if (string.IsNullOrWhiteSpace(line)) // Skip empty lines
//             {
//                 continue;
//             }

//             string[] parts = line.Split('|');
//             if (parts.Length != 2) // Ensure each line has exactly two parts
//             {
//                 Console.WriteLine($"Invalid line format: {line}");
//                 continue;
//             }

//             try
//             {
//                 Reference reference = Reference.Parse(parts[0]);
//                 string text = parts[1];
//                 scriptures.Add(new Scripture(reference, text));
//             }
//             catch (FormatException ex)
//             {
//                 Console.WriteLine($"Skipping invalid reference: {ex.Message}");
//             }
//         }
//     }
//     else
//     {
//         Console.WriteLine($"File {fileName} not found.");
//     }

//     return scriptures;
// }


//     // public static List<Scripture> LoadScripturesFromFile(string fileName)
//     // {
//     //     List<Scripture> scriptures = new List<Scripture>();

//     //     if (File.Exists(fileName))
//     //     {
//     //         string[] lines = File.ReadAllLines(fileName);

//     //         foreach (string line in lines)
//     //         {
//     //             string[] parts = line.Split('|');
//     //             if (parts.Length == 2)
//     //             {
//     //                 Reference reference = Reference.Parse(parts[0]);
//     //                 string text = parts[1];
//     //                 scriptures.Add(new Scripture(reference, text));
//     //             }
//     //         }
//     //     }
//     //     else
//     //     {
//     //         Console.WriteLine($"File {fileName} not found.");
//     //     }

//     //     return scriptures;
//     // }
// }