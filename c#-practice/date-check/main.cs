using System;
public class Program {
    public static bool TimeForMilkAndCookies(int year, int month, int day) {
        if(month == 0) return false;
        DateTime date =  new DateTime(year,month,day);
        DateTime target = new DateTime(year, 12, 24);
        return DateTime.Compare(date, target) == 0;
    }
}