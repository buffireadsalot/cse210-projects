using System;
using System.Drawing;
using System.Net;

class Program
{
    static void Main(string[] args)
    
    {
       Random randomGenerator = new Random();
       int x = randomGenerator.Next(1,99);
       int y = -1;
        
        while (x != y)
        {
            Console.WriteLine ("What is the magic number?  ");
            y = int.Parse(Console.ReadLine());
            
        
       
        
        if (y < x)
        {
            Console.WriteLine ("Higher");
        }
        else if (y > x)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine ("You guessed it!");
        }
          
        } 
     }
}  
