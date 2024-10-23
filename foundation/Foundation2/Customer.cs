using System;


public class Customer
{
    private string _customerName;

    private Address _customerAddress;

    public Customer(string Name, string streetaddress, string city, string region, string mailcode, string country)
    {
        _customerName = Name;
        _customerAddress = new Address(streetaddress, city, region, mailcode, country);
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress.DisplayAddress();
    }

    public bool ShippedInUS()
    {
        return _customerAddress.DetermineResidency();
    }
}