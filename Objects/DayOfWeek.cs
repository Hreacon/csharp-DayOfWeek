using System.Collections.Generic;
using System;
namespace DayOfWeekNS.Objects
{
  public class DayOfWeek
  {
    private static Dictionary<int, string> _days = new Dictionary<int,string> {
      {6, "Sunday"},
      {0, "Monday"},
      {1, "Tuesday"},
      {2, "Wedensday"},
      {3, "Thursday"},
      {4, "Friday"},
      {5, "Saturday"}
    };
    public DayOfWeek()
    {
    }

    public static string Do(int month, int day, int year)
    {
      int index = month + (day % 7) + YearCode(year);
      return _days[index % 7];
    }

    public static int YearCode(int year)
    {
      int yearCode = 0;
      for(int i = 2001;i<=year;i++)
      {
        if(year % 4 == 0 && !(year % 100 == 0) || year % 400 == 0)
        {
          yearCode += 2;
        } else yearCode += 1;
      }
      Console.WriteLine("Year: " +year+ " YearCode: " + yearCode % 7);
      return yearCode % 7;
    }
  } // end class
} // end namespace
