class Product
{
    private string _name;
    private string _id;
    private int _price;
    private int _unit;

    public void ShowProductInformation()
    {

    }

    public int CalculateProductAndUnit()
    {
        return _price * _unit;
    }
}