using Xunit;
using CoinNS.Objects;
namespace CoinNS
{
  public class CoinTest
  {
    //first test get pennies test for .04 expect return of 4
    [Fact]
    public void GetPennies_ForFourCents_4()
    {
      Assert.Equal(3, new Coin(.73).GetPennies());
    }
    //test for nickels for .05 expect return of 1
    [Fact]
    public void GetNickels_ForFiveCents_1()
    {
      Assert.Equal(1, new Coin(.69).GetNickels());
    }
    //test for dimes for .10 expect return of 1
    [Fact]
    public void GetDimes_ForTenCents_1()
    {
      Assert.Equal(2, new Coin(.73).GetDimes());
    }
    //test for quarters for .50 expect return of 2
    [Fact]
    public void GetQuarters_ForFiftyCents_2()
    {
      Assert.Equal(2, new Coin(.73).GetQuarters());
    }

  }
}
