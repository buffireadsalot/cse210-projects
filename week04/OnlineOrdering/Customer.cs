// public class Customer
// {
//     private string _name;
    
//     private string _email;
//     private string _phone;

//     private string _country;

//     private string _customerID;
//     private Address ShippingAddress;
//     private Address BillingAddress;
//     public Customer(string name, Address ShippingAddress, string country, string email, string phone)
//     {
//         _name = name;
//         Address shippingAddress = ShippingAddress;
//         if (country == "USA")
//         {
//             _country = null;
//         }
//         else
//         {
//             _country = country;
//         }
//         _email = email;
//         _phone = phone;
//     }
//     public string GetCountry()
//     {
//         return _country;
//     }
//     public string GetDisplayText()
//     {
//         return $"{_name}\n{ShippingAddress.GetDisplayText()}  {_country}\n{_email}\n{_phone}";
//     }
// }

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }

    public string GetShippingLabel()
    {
        return $"Customer: {_name}\nAddress:\n{_address.GetFullAddress()}";
    }
}
