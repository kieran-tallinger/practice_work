using System;
using System.Collections.Generic;
public class Program
    {
        public static string NameShuffle(string str)
        {
            string[] stringSeparators = new string[] {" "};
            string[] result;

            result = str.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            
            Array.Reverse(result);
            string reversed = String.Join(" ", result);
            return reversed;
        }
    }