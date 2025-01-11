using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in percentage?  ");
        string valueFromUser = Console.ReadLine();
        
        int g = int.Parse(valueFromUser);
        

        if (g >= 90)
        {
            Console.WriteLine ("You received an A");
        }
        else if (g >=80 && g < 90)
        { 
            Console.WriteLine("You received a B");
        }
        else if (g >= 70 && g !> 71)
        {
            Console.WriteLine("You received a C.");
        }
         else if (g >= 60 && g !> 61)
        {
            Console.WriteLine("You received a D.");
        }
         else 
        {
            Console.WriteLine("You received an F.");

        }
         if (g >= 70)
        {
            Console.WriteLine("You passed the class, congratulations.");
        }
          else if (g < 70)
        {
            Console.WriteLine("You did not pass, try again! It's never too late.");
        }
    }  
}