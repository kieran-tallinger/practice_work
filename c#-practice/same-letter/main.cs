public class Program {
    static public bool isIdentical(string str) {
        for (int index = 1; index < str.Length; index++) {
            if (str[index - 1] != str[index]) {
                return false;
            }
        }
        return true;
    }
}