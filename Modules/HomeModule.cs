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
        return View["index.cshtml"];
      };
      Post["/findDay"]= _ => {
        //run function Do()
        string output =  DayOfWeek.Do(int.Parse(Request.Form["month"]),
        int.Parse(Request.Form["day"]),
        int.Parse(Request.Form["year"]));
        return View["index.cshtml", output];
      };
    }
  }
}
