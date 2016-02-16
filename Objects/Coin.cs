using System.Collections.Generic;
using System;
namespace CoinNS.Objects
{
  public class Coin
  {
    private double _change;
    private int _quarters;
    private int _dimes;
    private int _nickels;
    private int _pennies;

    public Coin(double change)
    {
      SetChange(change);
    }

    public void SetChange(double change)
    {
      _change = change; // .73
      Console.WriteLine("Start change: " + change + " Quarters:" + change/.25);
      _quarters = (int)System.Math.Floor(change/.25);
      change = System.Math.Round( change - _quarters*.25, 2);
      Console.WriteLine(change + " Dimes:" + change/.1);
      _dimes = (int)System.Math.Floor(change/.1);
      change = System.Math.Round( change - _dimes*.1, 2);
      Console.WriteLine(change + " Nickels:" + change/.05);
      _nickels = (int)System.Math.Floor(change/.05);
      change = System.Math.Round( change - _nickels*.05, 2);
      Console.WriteLine(change + " Pennies:" + change/.01);
      _pennies = (int)System.Math.Floor(change/.01);
    }
    public double GetChange()
    {
      return _change;
    }
    public int GetPennies()
    {
      return _pennies;
    }
    public int GetDimes()
    {
      return _dimes;
    }
    public int GetNickels()
    {
      return _nickels;
    }
    public int GetQuarters()
    {
      return _quarters;
    }
  } // end class
} // end namespace
