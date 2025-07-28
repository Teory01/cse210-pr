public class Customer
{
    // Private field to store the customer's name
    private string _name;
    // Private field to store the customer's address
    private Address _address;

    // Constructor to initialize the customer's name and address
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to check if the customer lives in the USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method to get the customer's address
    public Address GetAddress()
    {
        return _address;
    }
}
