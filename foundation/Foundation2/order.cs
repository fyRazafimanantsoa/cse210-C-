public class Order
{
    // Member variables
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Methods
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        total += _customer.IsInUSA() ? 5 : 35; // Add shipping cost
        return total;
    }

    public string GeneratePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"Name: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
