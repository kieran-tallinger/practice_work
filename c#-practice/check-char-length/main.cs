using System.Linq;
using System.Collections.Generic;
public class Program {
    static public string[] IsFourLetters(string[] arr){
        return arr.Where(word => word.Length == 4).ToArray();
    }
}