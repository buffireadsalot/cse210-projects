using System;

class Program
{
    static void Main(string[] args)
    {
       Job Job1 = new Job();
       Job1._jobTitle = "Developer";
       Job1._companyName = "Microsoft";
       Job1._startYear = 2022;
       Job1._endyear = 2024;

       Job Job2 = new Job();
       Job2._jobTitle = "Programmer";
       Job2._companyName = "Piggly Wiggly";
       Job2._startYear = 2020;
       Job2._endyear = 2022;
    }

}