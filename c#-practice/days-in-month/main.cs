using System;

public class Program{
    public static int Days(int month, int year){
        return System.DateTime.DaysInMonth(year, month);
    }
}