// public class Address
// {
//     private string _street { get; set; }
//     private string _city { get; set; }
//     private string _state { get; set; }
//     private string _zip { get; set; }

//     public Address(string street, string city, string state, string zip)
//     {
//         _street = street;
//         _city = city;
//         _state = state;
//         _zip= zip;
//     }

//     public string GetDisplayText()
//     {
//         return $"/n{_street}, {_city}, {_state} {_zip}";
//     }
// }

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}