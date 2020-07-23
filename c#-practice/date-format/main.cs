using System;
public class Program {
    public static string FormatDate(string date) {
		DateTime input = DateTime.Parse(date);
        return input.ToString("yyyydMM");
    }
}