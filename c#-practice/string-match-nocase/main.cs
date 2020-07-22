using System;
public class Program{
    public static bool match(string s1, string s2){
			return String.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);	
    }
}