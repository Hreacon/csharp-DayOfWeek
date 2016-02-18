using Xunit;
using DayOfWeekNS.Objects;
namespace DayOfWeekNS
{
  public class DayOfWeekTest
  {
    [Fact]
    public void test1_enter_todaysDate_and_return_thursday()
    {
      Assert.Equal("Thursday", DayOfWeek.Do(2,18,2016));
    }
    [Fact]
    public void test2_enter_todaysDate_and_return_thursday()
    {
      Assert.Equal("Thursday", DayOfWeek.Do(1,1,2015));
    }
    [Fact]
    public void test3_enter_todaysDate_and_return_thursday()
    {
      Assert.Equal("Thursday", DayOfWeek.Do(4,18,2030));
    }
    [Fact]
    public void test4_enter_todaysDate_and_return_thursday()
    {
      Assert.Equal("Saturday", DayOfWeek.Do(5,20,2069));
    }
    [Fact]
    public void test5_enter_todaysDate_and_return_thursday()
    {
      Assert.Equal("Thursday", DayOfWeek.Do(12,14,2000));
    }

    /* EXAMPLE
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());
    }
    /**/
  }
}
