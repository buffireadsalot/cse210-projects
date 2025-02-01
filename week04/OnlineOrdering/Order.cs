// using System.Reflection.Metadata.Ecma335;

// public class Order
// {
       
//     private string _paymentMethod;
//     private string _paymentConfirmation;
//     private string _orderID;
   
//     private int _orderQuantity;
//     private decimal _shippingCost;
//      private Customer CustomerID;
//     private Address ShippingAddress;
//     private Address BillingAddress;
//     private Address Country;
//     private  List<Product> Items;

//     public decimal GetOrderQuantity { get; private set; }

//     public Order(decimal shippingCost)
//     {
//         Items = new List<Product>();
//         _shippingCost = shippingCost;
//     }

//     public void AddItem(Product item)
//     {
//         Items.Add(item);
//     }

//     public void RemoveItem(Product item)
//     {
//         Items.Remove(item);
//     }

//     public void SetShippingAddress(Address shippingAddress, Address country)
//     {
//         Address ShippingAddress = shippingAddress;
//        Address Country = country;
//     }

//     public void SetBillingAddress(Address billingAddress)
//     {
//         BillingAddress = billingAddress;
//     }

//     public void SetPaymentMethod(string paymentMethod)
//     {
//         _paymentMethod = paymentMethod;
//     }

//     public void SetPaymentConfirmation(string paymentConfirmation)
//     {
//         _paymentConfirmation = paymentConfirmation;
//     }
//     public void SetOrderID(string orderID)
//     {
//         _orderID = orderID;
//     }
//     public void SetCustomerID(Customer customerID)
//     {
//         CustomerID = customerID;
//     }
//     public void SetOrderQuantity(int orderQuantity)
//     {
//         _orderQuantity = orderQuantity;
//     }
//     public void SetItems(List<Product> items)
//     {
//         Items = items;
//         decimal totalPrice = items.Sum(item => item.GetPrice())*GetOrderQuantity;
//     }
//     public object GetCountry()
//     {
//          return Country;
//     }
//     public void SetShippingCost(decimal shippingCost)
//     {
//         // Assuming _country is defined elsewhere in the class
//         if (Country.ToString() == "USA")
//         {
//             _shippingCost = 5.00m;
//         }
//         else
//         {
//             _shippingCost = 35.00m;
//         }
//         _shippingCost = shippingCost;
//     }
//     public decimal GetTotalPrice()
//     {
//         return Items.Sum(item => item.GetPrice()) + _shippingCost;
//     }
//     public string GetDisplayText()
//     {
//         string itemsDisplay = string.Join("\n", Items.Select(item => item.GetDisplayText()));
//         return $"Shipping Address: {ShippingAddress.GetDisplayText()}\nBilling Address: {BillingAddress.GetDisplayText()}\nPayment Method: {_paymentMethod}\nPayment Confirmation: {_paymentConfirmation}\nItems:\n{itemsDisplay}";
//     }
// }

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal productTotal = _products.Sum(p => p.GetTotalCost());
        decimal shippingCost = _customer.LivesInUSA() ? 5.00m : 35.00m;
        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        return "Packing List:\n" + string.Join("\n", _products.Select(p => p.GetPackingLabel()));
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}