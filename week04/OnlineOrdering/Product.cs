public class Product
{
    // Declare private variables
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor to initialize the variables
    // Constructor for the Product class
    public Product(string name, string productId, double price, int quantity)
    {
        // Assign the name parameter to the _name field
        _name = name;
        // Assign the productId parameter to the _productId field
        _productId = productId;
        // Assign the price parameter to the _price field
        _price = price;
        // Assign the quantity parameter to the _quantity field
        _quantity = quantity;
    }

    // Method to calculate the total cost of the product
    // This method returns the total cost of the product
    public double GetTotalCost()
    {
        // Multiply the price of the product by the quantity of the product
        return _price * _quantity;
    }

    // Method to get the packing information of the product
    // This method returns a string containing the name and ID of the product
    public string GetPackingInfo()
    {
        // Return a string with the name and ID of the product
        return $"{_name} (ID: {_productId})";
    }
}

