using System;
using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private static List<Car> _instances = new List<Car>{};

    public Car(string newMakeModel, int newPrice, int newMiles)
    {
      _makeModel = newMakeModel;
      _price = newPrice;
      _miles = newMiles;
    }
    public string GetMakeModel()
    {
      return _makeModel;
    }
    public void SetMakeModel(string newNumberMake)
    {
      _makeModel = newNumberMake;
    }
    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newNumberPrice)
    {
      _price = newNumberPrice;
    }
    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newNumberMiles)
    {
      _miles = newNumberMiles;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }

    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
