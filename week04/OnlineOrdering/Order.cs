class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Methods
    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total += p.CalculateProductAndUnit();
        }

        double shipping;
        if (_customer.SetReside())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        return total + shipping;
    }
    // Packing label
    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetId()})\n";
        }
        return label;
    }

    // Shipping label
    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.ShowCustomer()}";
    }

}