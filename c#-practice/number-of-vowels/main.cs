using System.Text.RegularExpressions;
public class Program 
{
    public static int CountVowels(string str) 
    {
      string filter = "[aeiou]";
      return Regex.Matches(str, filter).Count;
    }
}