using Nancy;
using CoinNS.Objects;
using System.Collections.Generic;
namespace CoinNS
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
