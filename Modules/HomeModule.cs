using Nancy;
using DayOfWeekNS.Objects;
using System.Collections.Generic;
namespace DayOfWeekNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["header.cshtml"];
      };
    }
  }
}
