using Nancy;
using CoinNS.Objects;
using System.Collections.Generic;
using System;

namespace CoinNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/change"] = _ => {
        string Change = Request.Form["change"];
        int number = 0;
        try {
          number = int.Parse(Change);
        }
        catch (Exception ex)
        {
          Console.WriteLine("Message = {0}", ex.Message);
          Console.WriteLine("Source = {0}", ex.Source);
          Console.WriteLine("StackTrace = {0}", ex.StackTrace);
          Console.WriteLine("TargetSite = {0}", ex.TargetSite);
        }
        Coin newCoin = new Coin((double)number/ 100);
        return View["view-change.cshtml", newCoin];
      };
    }
  }
}
