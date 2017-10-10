using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    private static List<Car> _carsList = new List<Car> {};

    public Car (string makeModel, int price, int miles)
    {
       _makeModel = makeModel;
       _price = price;
       _miles = miles;
    }

    public void SetMake(string newMake)
    {
      _makeModel = newMake;
    }

    public string GetMake()
    {
      return _makeModel;
    }

    public void SetPrice(int newPrice)
    {
      if (newPrice >= 0) {
        _price = newPrice;
      }
      else {
        Console.WriteLine("The price for this item is not valid.");
      }
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
    public int GetMiles()
    {
      return _miles;
    }

    public void Save()
    {
      _carsList.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _carsList;
    }

    public static void ClearAll()
    {
      _carsList = new List<Car> {};
    }

    public bool MaxPrice(int maximumPossiblePrice)
    {
      if (_price <= maximumPossiblePrice)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool MaxMiles(int totalAcceptableMiles)
    {
      if (_miles <= totalAcceptableMiles)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
