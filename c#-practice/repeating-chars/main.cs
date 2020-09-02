using System;
using System.Text;
public class Program {
    static public string DoubleChar(string str) {
        StringBuilder sb = new System.Text.StringBuilder();
        for (int index = 0; index < str.Length; index++) {
            sb.Append(str[index]);
            sb.Append(str[index]);
        } 
        return sb.ToString();
    }
}