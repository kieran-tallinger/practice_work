using System;
using System.Globalization;
public class Program {
    static public string MonthName(int num) {
       return month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num); 
    }
}