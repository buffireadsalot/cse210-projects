using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }
    
       //function_body
        static void DisplayMessage ()
       {
        Console.WriteLine("Welcome to the program!");
       }
    static string PromptUserName ()
    {
        Console.WriteLine ("What is your name?  ");
        string name = Console.ReadLine();
        
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine ("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your favorite number is {number}.");

        return number;

    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
