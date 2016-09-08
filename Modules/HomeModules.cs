using Nancy;
using System;
using System.Collections.Generic;
using Cars.Objects;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["add_new_car.cshtml"];
      };
// ==============================================================
      Get["/view_all_cars"] = _ => {
      // List<Car> _instances = Car.GetAll();
      List<Car> allCars = Car.GetAll();
      return View["view_all_cars.cshtml", allCars];
      };
// ==============================================================
      Post["/added"] = _ => {
      string MakeModel = (Request.Form["MakeModel"]);
      int Price = (Request.Form["Price"]);
      int Miles = (Request.Form["Miles"]);
      Car newCar = new Car(MakeModel, Price, Miles);
      newCar.Save();
      return View["car_added.cshtml", newCar];
      };

      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
