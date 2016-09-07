using System;
using System.Collections.Generic;

namespace Cars.Objects
{
  class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;
    private static List<string> _instances = new List<string>{};

    public Car(string newMakeModel, int newPrice, int newMiles)
    {
      MakeModel = newMakeModel;
      Price = newPrice;
      Miles = newMiles;
    }

    public int GetMakeModel()
    {
      return MakeModel;
    }
    public void SetMakeModel(int newNumberMake)
    {
      MakeModel = newNumberMake;
    }
// add price & miles





    public static List<string> GetAll()
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
