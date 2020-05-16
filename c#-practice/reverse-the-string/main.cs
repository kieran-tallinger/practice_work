using System;
public class Program {
    public static string Reverse(string str) {
      char[] chars = str.ToCharArray();
      Array.Reverse( chars );
      return new string(chars);
    }
}
