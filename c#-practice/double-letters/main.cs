using System;
using System.Collections.Generic;
public class Program {
    public static bool DoubleLetters(string word) {
        HashSet<char> letters = new HashSet<char>();
        for (int i = 0; i < word.Length; i++) {
            char c = word[i];
            if (letters.Contains(c)) {
                return true;
            } else {
                letters.Clear();
                letters.Add(c);
            }
        }

        return false;
    }
}