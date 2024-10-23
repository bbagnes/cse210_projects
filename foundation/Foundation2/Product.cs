using System;


public class Product
{
    private string _productName; 
    private string _productId; 
    private double _productPrice;
    private int _productQuantity;
    
    public Product(string name, string id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _productPrice = price;
        _productQuantity = quantity;    
    }

    public double GetProductCost()
    {
        return _productPrice * _productQuantity;
    }

    public string GetProductInfo()
    {
        string productInfo = $"{_productName}, ID: {_productId} * {_productQuantity}\n";
        return productInfo;
    }
}