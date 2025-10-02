using System.Reflection.Metadata.Ecma335;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address Address)
    {
        _name = name;
        _address = Address;
    }

    // Getters y Setters
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }


    // Methods
    public bool SetReside()
    {
        return _address.SetReside();
    }

    public string ShowCustomer()
    {
        return $"{GetName}\n{_address.ShowAddress()}";
    }

}