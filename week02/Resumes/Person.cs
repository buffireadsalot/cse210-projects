using System;

public class Person
{
    //properties
    public string _firstName;
    public string _lastName;
    public string _streetAddress; //123 Main St.
    public string _city; //Anytown
    public string _state; //ST
    public string _zip; 
    public string _dob; //01-01-1999
    public string _gender //M, F, TF, TM, NB
    public string _sexAtBirth; //M, F, I
}
//Constructor
{
    public void Display()
    {
        Console.WriteLine ($"{_firtName} {_lastName}");
        Console.WriteLine ($"{_streetAddress}, {_city}, {_state} {_zip}");
        Console.WriteLine ($"Date of Birth: {_dob}");
        Console.WriteLine ($"Gender and Sex at Birth: {_gender} and {_sexAtBirth}")
    }

}

