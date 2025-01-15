using System;

public class Job 
{

    //properties
       public string _jobTitle;
       public string _companyName;

       public int _startYear;
       public int _endYear;

        //Constructor
        public void Display()
        {
            Console.WriteLine ($"{_jobTitle} ({_companyName}) {_startYear} -{_endYear}");
        }
    
}

   