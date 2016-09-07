using System;
using System.Collections.Generic;

namespace Cars.Objects
{
  public class Car
  {
    private string _makeModel;
    private int Price;
    private int Miles;
    private static List<Car> _instances = new List<Car>{};

    public Car(string newMakeModel, int newPrice, int newMiles)
    {
      _makeModel = newMakeModel;
      Price = newPrice;
      Miles = newMiles;
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
      return Price;
    }
// add price & miles





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
