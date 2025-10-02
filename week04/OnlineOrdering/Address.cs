class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // constructor
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    //getters and setters
    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }

    //Methods
    public bool SetReside()
    {
        return _country.ToUpper() == "USA";
    }

    public string ShowAddress()
    {
        return $"{SetStreet}\n{SetCity}, {SetState}\n{SetCountry}";
    }
}