using System;

class Program
{
    static void Main(string[] args)
    {
       Job Job1 = new Job();
       Job1._jobTitle = "National Sales Representative";
       Job1._companyName = "Visualutions, Inc.";
       Job1._startYear = 2003;
       Job1._endYear = 2024;

       Job Job2 = new Job();
       Job2._jobTitle = "Trainer";
       Job2._companyName = "AIS";
       Job2._startYear = 2002;
       Job2._endYear = 2003;

       Resume myResume = new Resume();
       myResume._name = "Name: Annela Buffin";

       myResume._jobs.Add(Job1);
       myResume._jobs.Add(Job2);

       myResume.Display();
    }

}