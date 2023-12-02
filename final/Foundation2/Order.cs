class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;

        foreach (var product in products)
        {
            totalPrice += product.GetPrice();
        }

        // Adding shipping cost based on customer location
        if (customer.IsInUSA())
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (var product in products)
        {
            packingLabel += $"{product.Name} - {product.ProductId}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{customer.Name}\n{customer.GetAddressAsString()}";
    }
}