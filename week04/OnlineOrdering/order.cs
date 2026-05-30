public class Order
{
    
    private List<Product> _products;
    private Customer _customer;

    
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    
    public decimal GetTotalCost()
    {
        decimal productsTotal = 0;
        
        
        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        
        decimal shippingCost = _customer.IsInUSA() ? 5m : 35m;

        
        return productsTotal + shippingCost;
    }

    
    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    
    public string GetShippingLabel()
    {
        string label = "--- Shipping Label ---\n";
        label += $"Customer: {_customer.GetName()}";
        label += _customer.GetAddress().GetFullAddressString();
        return label;
    }
}