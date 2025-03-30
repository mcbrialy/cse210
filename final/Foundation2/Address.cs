public class Address
{
    private string _street_address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street_address, string city, string state, string country)
    {
        _street_address = street_address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsAmerican()
    {
        if (_country == "America" || _country == "USA" || _country == "US" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetAddress()
    {
        return _street_address + "\t" + _city + ", " + _state + ", " + _country;
    }
}