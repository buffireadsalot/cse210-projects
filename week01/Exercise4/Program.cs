using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    { 
        List<int> numbers = new List<int>();
      
        int userNumber = -1;
        while (userNumber !=0)
    
            {
                Console.Write("Enter your number. Use 0 to quit: ");

                string userChoice = Console.ReadLine();
                userNumber = int.Parse(userChoice);

                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
                //Addition
         
     
                {
                int sum = 0;
                foreach (int number in numbers)
                {
                    sum+= number;
                }
                Console.WriteLine ($"The sum is: {sum}.");

                //Average
                float average = ((float)sum) / numbers.Count;
                Console.WriteLine ($"The average is {average}.");

                //Max number
                int max = numbers[0];
                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }
            Console.WriteLine($"The maximum number is {max}.");
            
            }
    
            
            
    }
}