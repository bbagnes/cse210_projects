using System;
using System.Collections.Concurrent;


public class Address
{
    private string _streetAddress;
    private string _city;
    private string _region;
    private string _mailingCode;
    private string _country;
    private bool _usResident;

    public Address(string streetaddress, string city, string region, string mailcode, string country)
    {
        _streetAddress = streetaddress;
        _city = city;
        _region = region;
        _mailingCode = mailcode;
        _country = country;
    }

    public bool DetermineResidency()
    {

        if (_country == "U.S.A.")
        {
            _usResident = true;
        }

        else if (_country == "United States")
        {
            _usResident = true;
        }

        else
        {
            _usResident = false;
        }

        return _usResident;
    }

    public string DisplayAddress()
    {        
        string address = $"{_streetAddress} \n{_city}, {_region} {_mailingCode} \n{_country}";
        return address;
    }

}