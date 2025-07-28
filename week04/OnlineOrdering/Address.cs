public class Address
{
    // Private fields for the Address class
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor for the Address class
    public Address(string street, string city, string state, string country)
    {
        // Assign the street parameter to the _street field
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // This method checks if the country is USA
    public bool IsInUSA()
    {
        // Check if the country is equal to "USA" in lowercase
        return _country.ToLower() == "usa";
    }

    // This method returns a full address string
    public string GetFullAddress()
    {
        // Return a string containing the street, city, state, and country
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
