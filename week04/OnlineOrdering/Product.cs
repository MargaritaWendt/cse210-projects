class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _unit;

    //constructor
    public Product(string name, string id, double price, int unit)
    {
        _name = name;
        _id = id;
        _price = price;
        _unit = unit;
    }

    //getters and setters
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetId()
    {
        return _id;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public int GetUnit()
    {
        return _unit;
    }

    public void SetUnit(int unit)
    {
        _unit = unit;
    }

    //methods
    public string ShowProductInformation()
    {
        return $"Producto: {GetName()}, ID: {GetId()}, Precio: ${GetPrice()}, Cantidad: {GetUnit()}";
    }

    public double CalculateProductAndUnit()
    {
        return _price * _unit;
    }
}