using System.Collections.Generic;
using System.Text;

public class Order
{
    //Create a private list to store the products in the cart
    private List<Product> _products;
    //Create a private customer object to store the customer information
    private Customer _customer;

    //Constructor to initialize the customer and products list
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    //Method to add a product to the cart
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //This method calculates the total price of all products in the cart and adds a shipping fee if the customer lives in the USA
    public double GetTotalPrice()
    {
        double total = 0;
        //Loop through each product in the cart
        foreach (var product in _products)
        {
            //Add the total cost of each product to the total
            total += product.GetTotalCost();
        }
        //Add a shipping fee if the customer lives in the USA
        total += _customer.LivesInUSA() ? 5 : 35;
        //Return the total price
        return total;
    }

    //This method returns a string containing the packing label for all products in the _products list
    public string GetPackingLabel()
    {
        //Create a new StringBuilder object to store the packing label
        StringBuilder label = new StringBuilder("Packing Label:\n");
        //Loop through each product in the _products list
        foreach (var product in _products)
        {
            //Append the packing information for each product to the label
            label.AppendLine(product.GetPackingInfo());
        }
        //Return the label as a string
        return label.ToString();
    }

    //This method returns a string containing the shipping label for the customer
    // This method returns a string containing the shipping label
    public string GetShippingLabel()
    {
        // Return a string with the shipping label, including the customer's name and address
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
