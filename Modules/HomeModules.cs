using Nancy;
// using FriendLetter.Objects;

namespace MadLibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>

      // {return View["hello.cshtml", myLetterVariables];};
    }
  }
}
