
class Customer
{
    public string Name { get; private set; }
    private Address Address { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetAddressAsString()
    {
        return Address.ToString();
    }
}
