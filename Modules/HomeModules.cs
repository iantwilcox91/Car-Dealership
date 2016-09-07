using Nancy;
using Cars.Objects;
using System.Collections.Generic;

namespace Cars
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];

      Get["/view_all_cars"] = _ => {
      List<string> _instances = _instances.GetAll();
      return View["view_all_cars.cshtml"]
      }

      Post["/Added"] = _ => {
      string MakeModel = (Request.Form["MakeModel"]);
      int Price = (Request.Form["Price"]);
      int Miles = (Request.Form["Miles"]);
      Car thisCar = new Car(MakeModel, Price, Miles);
      return View["car_added.cshtml", thisCar];
      };

      // Post["/cars_cleared"] = _ =>
      // return View
    }
  }
}
