// public class Product
// {
//     private string _name;
//     private decimal _price;
//     private string _productID;
//     private string _description;
//        private int _quantitySold;

//     public Product(string productID, string name, decimal price)
//     {
//         _productID = productID;
//         _name = name;
//         _price = price;
       
//     }

//     public string GetDisplayText()
//     {
//         return $"{_productID} - {_name} - ${_price}";
//     }

//     public decimal GetPrice()
//     {
//         return _price;
//     }


//     private List<Product> _products;

//     public Product()
//     {
//         _products = new List<Product>();
//     }

//     public void AddProduct(Product product)
//     {
//         _products.Add(product);
//     }
//     public decimal GetProductPrice()
//     {
//         return _products.Sum(product => product.GetPrice());
//     }
//     public string GetProductsDisplayText()
//     {
//         string productsDisplay = string.Join("\n", _products.Select(product => product.GetDisplayText()));
//         return $"Products:\n{productsDisplay}";
//     }
// }

public class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string productID, string name, decimal price, int quantity)
    {
        _productID = productID;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productID}) - Quantity: {_quantity}";
    }
}