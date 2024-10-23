using System;
using System.Numerics;
using System.Runtime.CompilerServices;


public class Order
{
    private Customer _customer;
    private List<Product> _productsList = new List<Product>();


    public Order(string Name, string streetaddress, string city, string region, string mailcode, string country)
    {
        _customer = new Customer(Name, streetaddress, city, region, mailcode, country);
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _productsList.Add(product);
    }

    public double CalculateOrderTotal()
    {
        double subtotal = 0;

        foreach (Product product in _productsList)
        {
        double productCost = product.GetProductCost();
        subtotal = subtotal + productCost;
        }

        double shippingCost = 0;
        if (_customer.ShippedInUS() == false)
        {
            shippingCost = 35;
        }
        else if (_customer.ShippedInUS() == true)
        {
            shippingCost = 5;
        }
        
        double OrderCost = subtotal + shippingCost;
        double totalOrderCost = Math.Round(OrderCost, 2);
        return totalOrderCost;
    }
    public string CreatePackingLabel()
    {
        string label = "";
        foreach (Product products in _productsList)
        {
            string subLabel = products.GetProductInfo();            
            label = label + subLabel;
        }
        return label;
    }
    
    public string CreateShippingLabel()
    {
        return $"{_customer.GetCustomerName()} \n{_customer.GetCustomerAddress()}";
    }

}