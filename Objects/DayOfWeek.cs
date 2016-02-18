using System.Collections.Generic;
using System;
namespace DayOfWeekNS.Objects
{
  public class DayOfWeek
  {
    private static Dictionary<int, string> _days = new Dictionary<int,string> {
      {0, "Sunday"},
      {1, "Monday"},
      {2, "Tuesday"},
      {3, "Wedensday"},
      {4, "Thursday"},
      {5, "Friday"},
      {6, "Saturday"}
    };
    private static Dictionary<int, int> _months = new Dictionary<int,int> {
      {1,6}, {2,2}, {3,2}, {4,5}, {5,0}, {6,3}, {7,5}, {8,1}, {9,4}, {10,6}, {11,2}, {12,4}
    };
    public DayOfWeek()
    {
    }

    public static string Do(int month, int day, int year)
    {
      int adjust = 0;
      if(month<=2 && isLeapYear(year))
      {
        adjust = -1;
      }
      month = _months[month] + adjust;
      int index = (month + (day % 7) + YearCode(year)) % 7;
      return _days[index];
    }
    public static bool isLeapYear(int year)
    {
      return (year % 4 == 0) && ((!(year % 100 == 0)) || (year % 400 == 0));
    }
    public static int YearCode(int year)
    {
      int yearCode = 0;
      for(int i = 2001;i<=year;i++)
      {
        if(DayOfWeek.isLeapYear(i))
        {
          // Console.WriteLine(i + " is leap year");
          yearCode += 2;
        } else yearCode += 1;
      }
      // Console.WriteLine("Year: " +year+ " YearCode: " + yearCode % 7);
      return yearCode % 7;
    }
  } // end class
} // end namespace
