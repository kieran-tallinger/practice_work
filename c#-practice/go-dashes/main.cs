using System;
using System.Text;

public class Program {
    public static string Go(int num) {
		StringBuilder dashes = new StringBuilder("", 60);

        for (int index = num; index > 0; index--) {
            dashes.Append("-");
        }

        string strDashes = dashes.ToString();
        return strDashes;
    }
}